
namespace WinFormsApp1
{
    partial class Home_Form
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
            this.subjects = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.Button();
            this.available_times = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.folder_output = new System.Windows.Forms.Label();
            this.view_timetables = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Save_file = new System.Windows.Forms.Label();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Save_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Grade_Calc_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjects
            // 
            this.subjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjects.FlatAppearance.BorderSize = 0;
            this.subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjects.Location = new System.Drawing.Point(0, 100);
            this.subjects.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(232, 60);
            this.subjects.TabIndex = 0;
            this.subjects.Text = "Subjects";
            this.subjects.UseVisualStyleBackColor = true;
            this.subjects.Click += new System.EventHandler(this.subjects_Click);
            // 
            // classes
            // 
            this.classes.Dock = System.Windows.Forms.DockStyle.Top;
            this.classes.FlatAppearance.BorderSize = 0;
            this.classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classes.Location = new System.Drawing.Point(0, 160);
            this.classes.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(232, 60);
            this.classes.TabIndex = 1;
            this.classes.Text = "Classes";
            this.classes.UseVisualStyleBackColor = true;
            this.classes.Click += new System.EventHandler(this.classes_Click);
            // 
            // available_times
            // 
            this.available_times.Dock = System.Windows.Forms.DockStyle.Top;
            this.available_times.FlatAppearance.BorderSize = 0;
            this.available_times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.available_times.Image = global::WinFormsApp1.Properties.Resources.Clock__2_;
            this.available_times.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.available_times.Location = new System.Drawing.Point(0, 220);
            this.available_times.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.available_times.Name = "available_times";
            this.available_times.Size = new System.Drawing.Size(232, 60);
            this.available_times.TabIndex = 2;
            this.available_times.Text = "N/A Times";
            this.available_times.UseVisualStyleBackColor = true;
            this.available_times.Click += new System.EventHandler(this.available_times_Click);
            // 
            // generate
            // 
            this.generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generate.Location = new System.Drawing.Point(505, 388);
            this.generate.MaximumSize = new System.Drawing.Size(10000, 1000);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(500, 50);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // folder_output
            // 
            this.folder_output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.folder_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folder_output.Location = new System.Drawing.Point(505, 230);
            this.folder_output.MaximumSize = new System.Drawing.Size(10000, 50);
            this.folder_output.Name = "folder_output";
            this.folder_output.Size = new System.Drawing.Size(500, 50);
            this.folder_output.TabIndex = 5;
            this.folder_output.Text = "Folder Output";
            this.folder_output.Click += new System.EventHandler(this.folder_output_Click);
            // 
            // view_timetables
            // 
            this.view_timetables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.view_timetables.Location = new System.Drawing.Point(493, 311);
            this.view_timetables.MaximumSize = new System.Drawing.Size(10000, 50);
            this.view_timetables.Name = "view_timetables";
            this.view_timetables.Size = new System.Drawing.Size(500, 50);
            this.view_timetables.TabIndex = 6;
            this.view_timetables.Text = "View Timetables";
            this.view_timetables.UseVisualStyleBackColor = true;
            this.view_timetables.Click += new System.EventHandler(this.view_timetables_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_Button.Location = new System.Drawing.Point(547, 526);
            this.Save_Button.MaximumSize = new System.Drawing.Size(200, 50);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(200, 37);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Save_file
            // 
            this.Save_file.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Save_file.Location = new System.Drawing.Point(770, 485);
            this.Save_file.MaximumSize = new System.Drawing.Size(200, 50);
            this.Save_file.Name = "Save_file";
            this.Save_file.Size = new System.Drawing.Size(200, 37);
            this.Save_file.TabIndex = 10;
            this.Save_file.Text = "Save File";
            this.Save_file.Click += new System.EventHandler(this.Save_file_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Load_Button.Location = new System.Drawing.Point(770, 526);
            this.Load_Button.MaximumSize = new System.Drawing.Size(200, 50);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(200, 37);
            this.Load_Button.TabIndex = 9;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Save_text
            // 
            this.Save_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_text.Location = new System.Drawing.Point(547, 491);
            this.Save_text.MaximumSize = new System.Drawing.Size(200, 50);
            this.Save_text.Name = "Save_text";
            this.Save_text.Size = new System.Drawing.Size(200, 31);
            this.Save_text.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 463);
            this.label2.MaximumSize = new System.Drawing.Size(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Save Name";
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
            this.panel1.TabIndex = 13;
            // 
            // Grade_Calc_Button
            // 
            this.Grade_Calc_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grade_Calc_Button.FlatAppearance.BorderSize = 0;
            this.Grade_Calc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grade_Calc_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Grade_Calc_Button.Location = new System.Drawing.Point(0, 280);
            this.Grade_Calc_Button.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.Grade_Calc_Button.Name = "Grade_Calc_Button";
            this.Grade_Calc_Button.Size = new System.Drawing.Size(232, 60);
            this.Grade_Calc_Button.TabIndex = 3;
            this.Grade_Calc_Button.Text = "GPA Calculator";
            this.Grade_Calc_Button.UseVisualStyleBackColor = true;
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(232, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 100);
            this.panel3.TabIndex = 1;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save_text);
            this.Controls.Add(this.Save_file);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.view_timetables);
            this.Controls.Add(this.folder_output);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.panel1);
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Button classes;
        private System.Windows.Forms.Button available_times;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label folder_output;
        private System.Windows.Forms.Button view_timetables;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label Save_file;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.TextBox Save_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Grade_Calc_Button;
        private System.Windows.Forms.Panel panel3;
    }
}