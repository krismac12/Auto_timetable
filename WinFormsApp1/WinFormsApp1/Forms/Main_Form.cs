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
            OpenChildForm(new Home_Form());
        }

        Form activeForm;

        private void OpenChildForm(Form childForm)
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
        }

        private void classes_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new Class_Form(this));
        }

        private void available_times_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new NA_Form(this));
        }

        private void Grade_Calc_Button_Click(object sender, EventArgs e)
        {

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home_Form());
        }
    }
}
