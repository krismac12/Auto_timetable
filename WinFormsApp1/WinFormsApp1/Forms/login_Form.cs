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
    public partial class login_Form : Form
    {
        public login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (KeyDB.Login(textBox1.Text))
            {
                XML.Login(textBox1.Text);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Invalid Key", "Error",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Key_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
