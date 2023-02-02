
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
            this.label1 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.folder_output = new System.Windows.Forms.Label();
            this.view_timetables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjects
            // 
            this.subjects.Location = new System.Drawing.Point(12, 30);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(112, 34);
            this.subjects.TabIndex = 0;
            this.subjects.Text = "Subjects";
            this.subjects.UseVisualStyleBackColor = true;
            this.subjects.Click += new System.EventHandler(this.subjects_Click);
            // 
            // classes
            // 
            this.classes.Location = new System.Drawing.Point(12, 130);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(112, 34);
            this.classes.TabIndex = 1;
            this.classes.Text = "Classes";
            this.classes.UseVisualStyleBackColor = true;
            this.classes.Click += new System.EventHandler(this.classes_Click);
            // 
            // available_times
            // 
            this.available_times.Location = new System.Drawing.Point(12, 230);
            this.available_times.Name = "available_times";
            this.available_times.Size = new System.Drawing.Size(112, 34);
            this.available_times.TabIndex = 2;
            this.available_times.Text = "N/A Times";
            this.available_times.UseVisualStyleBackColor = true;
            this.available_times.Click += new System.EventHandler(this.available_times_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(143, -43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 427);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(272, 130);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(203, 34);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // folder_output
            // 
            this.folder_output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.folder_output.Location = new System.Drawing.Point(272, 89);
            this.folder_output.Name = "folder_output";
            this.folder_output.Size = new System.Drawing.Size(203, 38);
            this.folder_output.TabIndex = 5;
            this.folder_output.Text = "Folder Output";
            this.folder_output.Click += new System.EventHandler(this.folder_output_Click);
            // 
            // view_timetables
            // 
            this.view_timetables.Location = new System.Drawing.Point(272, 230);
            this.view_timetables.Name = "view_timetables";
            this.view_timetables.Size = new System.Drawing.Size(203, 34);
            this.view_timetables.TabIndex = 6;
            this.view_timetables.Text = "View Timetables";
            this.view_timetables.UseVisualStyleBackColor = true;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 318);
            this.Controls.Add(this.view_timetables);
            this.Controls.Add(this.folder_output);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.available_times);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.subjects);
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Button classes;
        private System.Windows.Forms.Button available_times;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label folder_output;
        private System.Windows.Forms.Button view_timetables;
    }
}