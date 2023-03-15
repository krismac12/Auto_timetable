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
    public partial class Grade_form2 : Form
    {
        Main_Form main;
        Subject selected_subject;
        Grade selected;
        List<Grade> grades;
        public Grade_form2(Main_Form main,Subject selected)
        {
            this.main = main;
            this.selected_subject = selected;
            InitializeComponent();
            Grade_Label1.Text = "Grades for: " + selected.name;
            FillList();

        }

        private void FillList()
        {
            listBox1.Items.Clear();
            List<Subject> subjects = SubjectAccess.getSubjects();
            grades = GradeAcess.getGrades(subjects,selected_subject.ID);
            foreach (Grade grade in grades)
            {
                listBox1.Items.Add(grade);
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
                GradeAcess.deleteGrade(selected.ID);
                FillList();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = ((ListBox)sender).SelectedItem as Grade;
            if (listBox1.SelectedIndex == -1)
            {
                Assignment_box.Text = "";
                Grade_num.Value = 0;
            }
            else
            {
                Assignment_box.Text = selected.name;
                Grade_num.Value = Convert.ToInt32(selected.grade);
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string assignement = Assignment_box.Text;
            string grade = Convert.ToInt32(Grade_num.Value).ToString();
            int weight = Convert.ToInt32(Weight_num.Value);
            if (assignement == "" || grade == "" || weight <= 0)
            {

            }
            else
            {
                GradeAcess.insertGrade(selected_subject.ID,assignement,grade,weight);
                FillList();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string assignement = Assignment_box.Text;
            string grade = Convert.ToInt32(Grade_num.Value).ToString();
            int weight = Convert.ToInt32(Weight_num.Value);
            if (assignement == "" || grade == "" || listBox1.SelectedIndex == -1 || weight <= 0)
            {

            }
            else
            {
                GradeAcess.UpdateGrade(selected.ID,selected_subject.ID, assignement, grade,weight);
                FillList();
            }
        }
    }
}
