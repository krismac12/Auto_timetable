
namespace WinFormsApp1
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Grade_Calc_Button = new System.Windows.Forms.Button();
            this.available_times = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.Button();
            this.subjects = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Home_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.Grade_Calc_Button);
            this.panel1.Controls.Add(this.available_times);
            this.panel1.Controls.Add(this.classes);
            this.panel1.Controls.Add(this.subjects);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 664);
            this.panel1.TabIndex = 14;
            // 
            // Grade_Calc_Button
            // 
            this.Grade_Calc_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.Grade_Calc_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grade_Calc_Button.FlatAppearance.BorderSize = 0;
            this.Grade_Calc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grade_Calc_Button.Image = ((System.Drawing.Image)(resources.GetObject("Grade_Calc_Button.Image")));
            this.Grade_Calc_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Grade_Calc_Button.Location = new System.Drawing.Point(0, 280);
            this.Grade_Calc_Button.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.Grade_Calc_Button.Name = "Grade_Calc_Button";
            this.Grade_Calc_Button.Size = new System.Drawing.Size(232, 60);
            this.Grade_Calc_Button.TabIndex = 3;
            this.Grade_Calc_Button.Text = "GPA Calculator";
            this.Grade_Calc_Button.UseVisualStyleBackColor = false;
            this.Grade_Calc_Button.Click += new System.EventHandler(this.Grade_Calc_Button_Click);
            // 
            // available_times
            // 
            this.available_times.Dock = System.Windows.Forms.DockStyle.Top;
            this.available_times.FlatAppearance.BorderSize = 0;
            this.available_times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.available_times.Image = ((System.Drawing.Image)(resources.GetObject("available_times.Image")));
            this.available_times.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.available_times.Location = new System.Drawing.Point(0, 220);
            this.available_times.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.available_times.Name = "available_times";
            this.available_times.Size = new System.Drawing.Size(232, 60);
            this.available_times.TabIndex = 2;
            this.available_times.Text = "N/A Times";
            this.available_times.UseVisualStyleBackColor = true;
            this.available_times.Click += new System.EventHandler(this.available_times_Click_1);
            // 
            // classes
            // 
            this.classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.classes.Dock = System.Windows.Forms.DockStyle.Top;
            this.classes.FlatAppearance.BorderSize = 0;
            this.classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classes.Image = ((System.Drawing.Image)(resources.GetObject("classes.Image")));
            this.classes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classes.Location = new System.Drawing.Point(0, 160);
            this.classes.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(232, 60);
            this.classes.TabIndex = 1;
            this.classes.Text = "Classes";
            this.classes.UseVisualStyleBackColor = false;
            this.classes.Click += new System.EventHandler(this.classes_Click_1);
            // 
            // subjects
            // 
            this.subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.subjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjects.FlatAppearance.BorderSize = 0;
            this.subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjects.Image = ((System.Drawing.Image)(resources.GetObject("subjects.Image")));
            this.subjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjects.Location = new System.Drawing.Point(0, 100);
            this.subjects.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(232, 60);
            this.subjects.TabIndex = 0;
            this.subjects.Text = "Subjects";
            this.subjects.UseVisualStyleBackColor = false;
            this.subjects.Click += new System.EventHandler(this.subjects_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.Home_Button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(232, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 100);
            this.panel3.TabIndex = 4;
            // 
            // Main_Panel
            // 
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_Panel.Location = new System.Drawing.Point(232, 100);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1026, 564);
            this.Main_Panel.TabIndex = 15;
            // 
            // Home_Button
            // 
            this.Home_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Home_Button.FlatAppearance.BorderSize = 0;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.Location = new System.Drawing.Point(0, 0);
            this.Home_Button.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(113, 100);
            this.Home_Button.TabIndex = 4;
            this.Home_Button.UseVisualStyleBackColor = false;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Grade_Calc_Button;
        private System.Windows.Forms.Button available_times;
        private System.Windows.Forms.Button classes;
        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Button Home_Button;
    }
}