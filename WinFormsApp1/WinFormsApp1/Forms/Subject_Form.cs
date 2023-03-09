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
    public partial class Subject_Form : Form
    {
        public List<Subject> subjects;
        public Subject selected;
        Main_Form main;
        public Subject_Form(Main_Form form)
        {
            InitializeComponent();
            FillList();
            main = form;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            selected = ((ListBox)sender).SelectedItem as Subject;
            if (listBox1.SelectedIndex == -1)
            {
                Name_box.Text = "";
                Code_Box.Text = "";
            }
            else
            {
                Name_box.Text = selected.name;
                Code_Box.Text = selected.code;
            }

        }

        private void Name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Code_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillList()
        {
            listBox1.Items.Clear();
            subjects = SubjectAccess.getSubjects();
            foreach(Subject sub in subjects)
            {
                listBox1.Items.Add(sub);
            }
            Name_box.Text = "";
            Code_Box.Text = "";
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string code = Code_Box.Text;
            string name = Name_box.Text;
            if(code == "" || name == "")
            {

            }
            else
            {
                SubjectAccess.insertSubject(name, code);
                FillList();
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            string code = Code_Box.Text;
            string name = Name_box.Text;
            if (code == "" || name == "" || listBox1.SelectedIndex == -1)
            {

            }
            else
            {
                SubjectAccess.UpdateSubject(name, code, selected.ID);
                FillList();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                Name_box.Text = "";
                Code_Box.Text = "";
            }
            else
            {
                
                SubjectAccess.deleteSubject(selected.ID);
                FillList();
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Classes_button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {

            }
            else
            {
                if(selected != null)
                {
                    var myForm = new Class_Form(main, selected);
                    main.OpenChildForm(myForm);
                }
            }
        }
    }
}
