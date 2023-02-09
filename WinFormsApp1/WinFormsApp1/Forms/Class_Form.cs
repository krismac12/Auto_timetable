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
        Subject subject;
        Subject selectedSubject;
        Class selected;
        Form home;
        public Class_Form(Form form)
        {
            type = 1;
            subjects = SubjectAccess.getSubjects();
            classes = ClassAccess.getClasses(subjects);
            InitializeComponent();
            FillList();
            FillCombo();
            home = form;
            Subject_Label.Text = "";

        }

        public Class_Form(Form form,Subject subject)
        {
            type = 2;
            subjects = SubjectAccess.getSubjects();
            classes = ClassAccess.getClasses(subjects,subject.ID);
            this.subject = subject;
            InitializeComponent();
            FillList();
            FillCombo();
            home = form;
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
            this.Hide();
            home.Show();
        }

        private void Times_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {

            }
            else
            {
                this.Hide();
                var myForm = new Time_Form(selected,classes,this);
                myForm.Show();
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
    }
}
