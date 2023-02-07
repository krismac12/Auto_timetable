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
    public partial class Home_Form : Form
    {
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
            List<Subject> subjects = SubjectAccess.getSubjects();
            List<Class> classes = ClassAccess.getClasses(subjects);
            foreach (Class @class in classes)
            {
                List<Time> times = TimeAcess.getTimes(classes, @class.ID);
            }

            List<Time> NA = TimeAcess.getNA();
            Generator g = new Generator(classes, NA);
            g.generateTimetables(50);
            foreach (Timetable table in g.timetables)
            {
                table.pTable();
            }
        }

        private void folder_output_Click(object sender, EventArgs e)
        {

        }

        private void view_timetables_Click(object sender, EventArgs e)
        {

        }
    }
}
