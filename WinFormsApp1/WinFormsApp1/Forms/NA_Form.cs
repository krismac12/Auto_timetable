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
    public partial class NA_Form : Form
    {
        private DateTime sunday = new DateTime(2023, 2, 5);
        private DateTime monday = new DateTime(2023, 2, 6);
        private DateTime tuesday = new DateTime(2023, 2, 7);
        private DateTime wednesday = new DateTime(2023, 2, 8);
        private DateTime thursday = new DateTime(2023, 2, 9);
        private DateTime friday = new DateTime(2023, 2, 10);
        private DateTime saturday = new DateTime(2023, 2, 11);

        List<Time> times = new List<Time>();
        List<DateTime> days = new List<DateTime>();
        Time selected;
        Form home;

        public NA_Form(Form form)
        {
            InitializeComponent();

            home = form;

            days.Add(sunday);
            days.Add(monday);
            days.Add(tuesday);
            days.Add(wednesday);
            days.Add(thursday);
            days.Add(friday);
            days.Add(saturday);


            FillList();
            FillCombo();
            Start_Picker.ShowUpDown = true;
            Start_Picker.CustomFormat = "hh:mm tt";
            Start_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            End_Picker.ShowUpDown = true;
            End_Picker.CustomFormat = "hh:mm tt";
            End_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        private void FillCombo()
        {

            Day_Box.Items.Add("Sunday");
            Day_Box.Items.Add("Monday");
            Day_Box.Items.Add("Tuesday");
            Day_Box.Items.Add("Wednesday");
            Day_Box.Items.Add("Thursday");
            Day_Box.Items.Add("Friday");
            Day_Box.Items.Add("Saturday");

        }

        private void FillList()
        {
            listBox1.Items.Clear();
            times = TimeAcess.getNA();
            foreach (Time t in times)
            {
                listBox1.Items.Add(t);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = ((ListBox)sender).SelectedItem as Time;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Type_box.Text == "" || Day_Box.SelectedIndex == -1)
            {
            }
            else
            {
                DateTime start = days[Day_Box.SelectedIndex].AddHours(Start_Picker.Value.Hour).AddMinutes(Start_Picker.Value.Minute);
                DateTime end = days[Day_Box.SelectedIndex].AddHours(End_Picker.Value.Hour).AddMinutes(End_Picker.Value.Minute);
                if (end > start)
                {
                    TimeAcess.insertNA(2, Type_box.Text, start.ToString(), end.ToString());
                    FillList();
                }
                else
                {
                    MessageBox.Show("Please make End time After Start Time", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                TimeAcess.deleteTime(selected.ID);
                FillList();
            }
        }
    }
}
