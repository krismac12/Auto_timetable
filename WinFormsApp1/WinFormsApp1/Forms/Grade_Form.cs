﻿using System;
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
                    main.OpenChildForm(myForm);
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
    }
}
