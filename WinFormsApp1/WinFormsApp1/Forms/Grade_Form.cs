using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Grade_Form : Form
    {
        public List<Subject> subjects;
        public Subject selected;
        Main_Form main;
        Class_Form class_Form;
        public Grade_Form(Main_Form form)
        {
            InitializeComponent();
            FillList();
            main = form;
        }


        private void FillList()
        {
            listBox.Items.Clear();
            subjects = SubjectAccess.getSubjects();
            foreach (Subject sub in subjects)
            {
                listBox.Items.Add(sub);
            }
            nameBox.Text = "";
            codeBox.Text = "";
        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = ((ListBox)sender).SelectedItem as Subject;
            if (listBox.SelectedIndex == -1)
            {
                nameBox.Text = "";
                codeBox.Text = "";
            }
            else
            {
                nameBox.Text = selected.name;
                codeBox.Text = selected.code;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string code = codeBox.Text;
            string name = nameBox.Text;
            if (code == "" || name == "")
            {

            }
            else
            {
                SubjectAccess.insertSubject(name, code);
                FillList();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string code = codeBox.Text;
            string name = nameBox.Text;
            if (code == "" || name == "" || listBox.SelectedIndex == -1)
            {

            }
            else
            {
                SubjectAccess.UpdateSubject(name, code, selected.ID);
                FillList();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                nameBox.Text = "";
                codeBox.Text = "";
            }
            else
            {

                SubjectAccess.deleteSubject(selected.ID);
                FillList();
            }
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {

            }
            else
            {
                if (selected != null)
                {
                    var myForm = new Grade_form2(main,selected);
                    main.OpenChildForm(myForm,"Grades");
                }
            }
        }

        private void Folder_text_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Folder_text.Text = diag.SelectedPath;
            }
            else
            {
                Folder_text.Text = "Save Folder";
            }
        }

        private void Download_button_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(Folder_text.Text) && Save_text.Text != "")
            {
                List<Subject> graded = new List<Subject>();

                subjects = SubjectAccess.getSubjects();

                List<Grade> grades = GradeAcess.getGrades(subjects);
                foreach (Subject subject in subjects)
                {
                    if (subject.grades.Count > 0)
                    {
                        graded.Add(subject);
                    }
                }

                string output = "";
                foreach (Subject subject in graded)
                {
                    subject.calculateGrade();
                    output += subject.name + ": " + subject.Grade + "\n";
                }
                string filePath = Folder_text.Text + "\\Grades";

                StringToPdf(output, filePath,Save_text.Text);
            }
        }

        public void StringToPdf(string inputString, string folderPath, string fileName)
        {
            // create the folder if it doesn't exist
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // append the .pdf extension to the file name if it's not already there
            if (!fileName.EndsWith(".pdf"))
            {
                fileName += ".pdf";
            }

            // create the full output file path
            string outputPath = Path.Combine(folderPath, fileName);

            // create a new Document object
            Document document = new Document();

            // add a new section to the document
            Section section = document.AddSection();

            // create a new Paragraph object
            Paragraph paragraph = section.AddParagraph();

            // split the input string by line breaks and add each line as a new paragraph
            string[] lines = inputString.Split('\n');
            foreach (string line in lines)
            {
                // add the line to the paragraph
                paragraph.AppendText(line);

                // add a line break
                paragraph.AppendBreak(BreakType.LineBreak);
            }

            // save the document as a PDF
            document.SaveToFile(outputPath, FileFormat.PDF);

            // dispose of the document
            document.Dispose();

            MessageBox.Show("Finished Outputting Grades", "INFO",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void View_Button_Click(object sender, EventArgs e)
        {
            OpenFolder(Folder_text.Text);
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);

            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }
    }
}
