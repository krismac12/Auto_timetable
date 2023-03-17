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
        Main_Form main;

        public NA_Form(Main_Form form)
        {
            InitializeComponent();

            main = form;

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
            Application.Restart();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Type_box.Text == "" || Day_Box.SelectedIndex == -1 || ((int)Start_num.Value) <= 0 || ((int)End_num.Value) <= 0)
            {
            }
            else
            {
                DateTime start = days[Day_Box.SelectedIndex].AddHours(Start_Picker.Value.Hour).AddMinutes(Start_Picker.Value.Minute);
                DateTime end = days[Day_Box.SelectedIndex].AddHours(End_Picker.Value.Hour).AddMinutes(End_Picker.Value.Minute);
                if (end > start)
                {
                    if (((int)Start_num.Value) < ((int)End_num.Value)) 
                    { 
                        TimeAcess.insertNA(2, Type_box.Text, start.ToString(), end.ToString(), ((int)Start_num.Value), ((int)End_num.Value));
                        FillList();
                    }
                    else
                    {
                        MessageBox.Show("Please make End Week After Start Week", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Type_box.Text == "" || Day_Box.SelectedIndex == -1 || Start_num.Value == 0 || End_num.Value == 0 || listBox1.SelectedIndex == -1)
            {

            }
            else
            {
                DateTime start = days[Day_Box.SelectedIndex].AddHours(Start_Picker.Value.Hour).AddMinutes(Start_Picker.Value.Minute);
                DateTime end = days[Day_Box.SelectedIndex].AddHours(End_Picker.Value.Hour).AddMinutes(End_Picker.Value.Minute);
                if (end > start)
                {
                    TimeAcess.UpdateTime(selected.ID, 2, Type_box.Text, start.ToString(), end.ToString(), ((int)Start_num.Value), ((int)End_num.Value));
                }
            }
            FillList();
        }

        private void Delete_Button_Click_1(object sender, EventArgs e)
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

        private void Edit_Click_1(object sender, EventArgs e)
        {
            if (Type_box.Text == "" || Day_Box.SelectedIndex == -1 || Start_num.Value == 0 || End_num.Value == 0 || listBox1.SelectedIndex == -1)
            {

            }
            else
            {
                DateTime start = days[Day_Box.SelectedIndex].AddHours(Start_Picker.Value.Hour).AddMinutes(Start_Picker.Value.Minute);
                DateTime end = days[Day_Box.SelectedIndex].AddHours(End_Picker.Value.Hour).AddMinutes(End_Picker.Value.Minute);
                if (end > start)
                {
                    TimeAcess.UpdateTime(selected.ID, 2, Type_box.Text, start.ToString(), end.ToString(), ((int)Start_num.Value), ((int)End_num.Value));
                }
            }
            FillList();
        }

        private void Add_Button_Click_1(object sender, EventArgs e)
        {
            if (Type_box.Text == "" || Day_Box.SelectedIndex == -1 || ((int)Start_num.Value) <= 0 || ((int)End_num.Value) <= 0)
            {
            }
            else
            {
                DateTime start = days[Day_Box.SelectedIndex].AddHours(Start_Picker.Value.Hour).AddMinutes(Start_Picker.Value.Minute);
                DateTime end = days[Day_Box.SelectedIndex].AddHours(End_Picker.Value.Hour).AddMinutes(End_Picker.Value.Minute);
                if (end > start)
                {
                    if (((int)Start_num.Value) < ((int)End_num.Value))
                    {
                        TimeAcess.insertNA(2, Type_box.Text, start.ToString(), end.ToString(), ((int)Start_num.Value), ((int)End_num.Value));
                        FillList();
                    }
                    else
                    {
                        MessageBox.Show("Please make End Week After Start Week", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please make End time After Start Time", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Day_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Start_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Type_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void End_num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Start_num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void End_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Constraint_Button_Click(object sender, EventArgs e)
        {
            main.OpenChildForm(new Constraints_Form(main,this),"Time Constraints");
            main.ActiveButton(main.available_times, Color.FromArgb(235, 104, 104));
        }
    }
}
