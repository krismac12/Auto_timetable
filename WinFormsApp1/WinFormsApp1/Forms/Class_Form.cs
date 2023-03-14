using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Class_Form : Form
    {
        private List<Class> classes = new List<Class>();
        private List<Subject> subjects = new List<Subject>();
        private int type;
        public Subject subject;
        Subject selectedSubject;
        Class selected;
        Main_Form main;
        Form subject_Form1;
        public Class_Form(Main_Form form)
        {
            type = 1;
            subjects = SubjectAccess.getSubjects();
            classes = ClassAccess.getClasses(subjects);
            InitializeComponent();
            FillList();
            FillCombo();
            main = form;
            Subject_Label.Text = "";
            Back_Button.Visible = false;

        }

        public Class_Form(Main_Form form,Subject subject)
        {
            type = 2;
            subjects = SubjectAccess.getSubjects();
            classes = ClassAccess.getClasses(subjects,subject.ID);
            this.subject = subject;
            InitializeComponent();
            FillList();
            FillCombo();
            main = form;
            subject_Form1 = new Subject_Form(main);
            Subject_Label.Text = "Classes for : " + subject.name;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            string code = Code_Box.Text;
            string name = Name_box.Text;
            if (code == "" || name == "" || Subject_Box.SelectedIndex == -1||listBox1.SelectedIndex == -1)
            {

            }
            else
            {
                ClassAccess.UpdateClass(name,code,selected.ID,selectedSubject.ID); ;
                FillList();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                FillList();
            }
            else
            {
                ClassAccess.deleteClass(selected.ID);
                FillList();
            }
        }

        private void Times_Button_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string code = Code_Box.Text;
            string name = Name_box.Text;
            if (code == "" || name == ""|| Subject_Box.SelectedIndex == -1)
            {

            }
            else
            {
                ClassAccess.insertClass(name, code,selectedSubject.ID);
                FillList();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = ((ListBox)sender).SelectedItem as Class;
            if (listBox1.SelectedIndex == -1)
            {
                Name_box.Text = "";
                Code_Box.Text = "";
            }
            else
            {
                Name_box.Text = selected.name;
                Code_Box.Text = selected.code;
                Subject_Box.SelectedItem = selected.subject;
                Subject_Box.Text = selected.subject.ToString();
            }
        }

        private void Name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Code_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subject_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Subject_Box.SelectedIndex != -1)
            {
                selectedSubject = ((ComboBox)sender).SelectedItem as Subject;

            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            if(subject != null)
            {
                main.OpenChildForm(subject_Form1);
                main.ActiveButton(main.subjects, Color.FromArgb(200, 162, 200));
            }
            else
            {

            }
        }

        private void Times_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {

            }
            else
            {
                var myForm = new Time_Form(selected,classes,this,main);
                main.ActiveButton(main.classes, Color.FromArgb(235, 104, 104));
                main.OpenChildForm(myForm);
            }

        }

        private void FillList()
        {
            if(type == 1)
            {
                listBox1.Items.Clear();
                classes = ClassAccess.getClasses(subjects);
                foreach (Class @class in classes)
                {
                    listBox1.Items.Add(@class);
                }
                Name_box.Text = "";
                Code_Box.Text = "";
                Subject_Box.SelectedIndex = -1;
            }
            else
            {
                listBox1.Items.Clear();
                classes = ClassAccess.getClasses(subjects,subject.ID);
                foreach (Class @class in classes)
                {
                    listBox1.Items.Add(@class);
                }
                Name_box.Text = "";
                Code_Box.Text = "";
                Subject_Box.SelectedIndex = -1;
            }
        }

        private void FillCombo()
        {
            subjects = SubjectAccess.getSubjects();
            foreach (Subject subject in subjects)
            {
                Subject_Box.Items.Add(subject);
            }
        }

        private void Subject_Label_Click(object sender, EventArgs e)
        {

        }

        private void Class_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
