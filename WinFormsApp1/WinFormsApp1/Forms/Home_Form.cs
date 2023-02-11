using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Spire.Xls;

namespace WinFormsApp1
{
    public partial class Home_Form : Form
    {
        Generator g;
        int num;
        public Home_Form()
        {
            InitializeComponent();
        }

        private void subjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Subject_Form(this);
            myForm.Show();
        }

        private void classes_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<Subject> subjects = SubjectAccess.getSubjects();
            var myForm = new Class_Form(this);
            myForm.Show();
        }

        private void available_times_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new NA_Form(this);
            myForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (!TimeAcess.isEmpty())
            {
                if (Directory.Exists(folder_output.Text))
                {
                    generateTables();

                    if(g.timetables.Count == 0)
                    {
                        MessageBox.Show("No Timetables possible for current data", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string filePath = folder_output.Text;
                    //loop
                    int i = 1;
                    foreach (Timetable table in g.timetables)
                    {
                        string destination = "./DB/excelfile.xlsx";
                        CreateExcel("./DB/Schedule_template.xlsx", destination);

                        writeTable(destination, table);
                        FileInfo existingFile = new FileInfo(destination);

                        string pdfFile = filePath + "\\Timetable" + i + ".pdf";

                        Workbook workbook = new Workbook();
                        workbook.LoadFromFile(destination);

                        Worksheet sheet = workbook.Worksheets[0];
                        sheet.PageSetup.Orientation = PageOrientationType.Landscape;
                        sheet.PageSetup.FitToPagesTall = 1;

                        workbook.SaveToFile(pdfFile, FileFormat.PDF);
                        File.Delete(destination);
                        i++;
                        if (i > num)
                        {
                            break;
                        }
                    }
                    MessageBox.Show("Finished Generating Timetables", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select a Folder", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Create Times", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void folder_output_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if(diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folder_output.Text = diag.SelectedPath;
            }
            else
            {
                folder_output.Text = "Folder Output";
            }
        }

        private void view_timetables_Click(object sender, EventArgs e)
        {
            OpenFolder(folder_output.Text);
        }

        private void generateTables()
        {
            List<Subject> subjects = SubjectAccess.getSubjects();
            List<Class> classes = ClassAccess.getClasses(subjects);
            foreach (Class @class in classes)
            {
                List<Time> times = TimeAcess.getTimes(classes, @class.ID);
            }

            List<Time> NA = TimeAcess.getNA();

            int gens = 1;
            int count;
            foreach (Class @class in classes)
            {
                if (@class.times.Count >= 1)
                {
                    gens = gens * @class.times.Count;
                }
            }
            if (gens <= 25)
            {
                count = gens + 2;
            }
            else
            {
                count = 25;
            }
            num = gens;
            g = new Generator(classes, NA);
            g.generateTimetables(count);
        }

        private void writeTable(string file,Timetable table)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            var fileinfo = new FileInfo(file);
            List<Time> sunday = new List<Time>();
            List<Time> monday = new List<Time>();
            List<Time> tuesday = new List<Time>();
            List<Time> wednesday = new List<Time>();
            List<Time> thursday = new List<Time>();
            List<Time> friday = new List<Time>();
            List<Time> saturday = new List<Time>();

            List<List<Time>> lists = new List<List<Time>>();
            lists.Add(sunday);
            lists.Add(monday);
            lists.Add(tuesday);
            lists.Add(wednesday);
            lists.Add(thursday);
            lists.Add(friday);
            lists.Add(saturday);




            foreach (Time time in table.times)
            {
                switch (time.start.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        sunday.Add(time);
                        break;

                    case DayOfWeek.Monday:
                        monday.Add(time);
                        break;

                    case DayOfWeek.Tuesday:
                        tuesday.Add(time);
                        break;

                    case DayOfWeek.Wednesday:
                        wednesday.Add(time);
                        break;

                    case DayOfWeek.Thursday:
                        thursday.Add(time);
                        break;

                    case DayOfWeek.Friday:
                        friday.Add(time);
                        break;

                    case DayOfWeek.Saturday:
                        saturday.Add(time);
                        break;



                    default:
                        // code block
                        break;
                }
            }



            using (ExcelPackage p = new ExcelPackage(fileinfo))
            {
                ExcelWorksheet ws = p.Workbook.Worksheets[0];

                ws.Rows.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Rows.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;
                ws.Rows.Style.WrapText = true;
                int a = 1;
                foreach (List<Time> times in lists)
                {
                    int b = 2;
                    foreach (Time time in times)
                    {
                        ws.Cells[b, a].Value = time.Display();
                        b++;
                    }
                    a++;
                }
                p.Save();
            }


        }

        private static void CreateExcel(string source,string destinationFile)
        {
            try
            {
                File.Copy(source, destinationFile, true);
            }
            catch (IOException iox)
            {
                System.Diagnostics.Debug.WriteLine(iox.Message);
            }
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

        private void Save_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "Database file (*.db)|*.db";
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Save_file.Text = diag.FileName;
            }
            else
            {
                Save_file.Text = "Save File";
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("./DB/auto_timetable.db"))
                {
                    File.Delete("./DB/auto_timetable.db");
                }

                if (Save_file.Text != "")
                {
                    try
                    {
                        File.Copy(Save_file.Text, "./DB/auto_timetable.db");
                        MessageBox.Show("Save File " + Save_file.Text + " Loaded", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Wait DB file is still in use", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Wait DB file is still in use , if persists close the application", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (Save_text.Text != "")
            {
                try
                {
                    File.Copy("./DB/auto_timetable.db", "./Saves/" + Save_text.Text + ".db");
                    MessageBox.Show("Save File " + Save_text.Text + " Saved", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Save File Already Exists", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
