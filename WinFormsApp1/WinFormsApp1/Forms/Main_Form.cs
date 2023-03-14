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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        Form activeForm;
        Button current = null;

        public void ActiveButton(Button button,Color color)
        {
            if(current != null)
            {
                current.BackColor = Color.FromArgb(51, 51, 71);
                current.ForeColor = Color.Gainsboro;
                current.Enabled = true;
            }

            current = button;
            current.ForeColor = Color.White;
            current.BackColor = color;
            current.Enabled = false;


            panel3.BackColor = color;
            Home_Button.BackColor = color;

        }

        private void DisableButton()
        {
            if(current != null)
            {
                current.BackColor = Color.FromArgb(51, 51, 71);
                current.ForeColor = Color.Gainsboro;
                current.Enabled = true;
                current = null;
            }


            panel3.BackColor = Color.FromArgb(39, 39, 58);
            Home_Button.BackColor = Color.FromArgb(39, 39, 58);
        }
        public void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Main_Panel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }


        private void subjects_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Subject_Form(this));
            ActiveButton(subjects,Color.FromArgb(200, 162, 200));
        }

        private void classes_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new Class_Form(this));
            ActiveButton(classes, Color.FromArgb(212, 176, 83));
        }

        private void available_times_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new NA_Form(this));
            ActiveButton(available_times, Color.FromArgb(235, 104, 104));
        }

        private void Grade_Calc_Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Grade_Form(this));
            ActiveButton(Grade_Calc_Button, Color.FromArgb(101, 92, 214));

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            DisableButton();
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home_Form());
            ActiveButton(OutputButton, Color.FromArgb(110, 250, 227));
        }
    }
}
