
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
            this.generate = new System.Windows.Forms.Button();
            this.folder_output = new System.Windows.Forms.Label();
            this.view_timetables = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Save_file = new System.Windows.Forms.Label();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Save_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generate.Location = new System.Drawing.Point(448, 122);
            this.generate.MaximumSize = new System.Drawing.Size(10000, 1000);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(138, 37);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // folder_output
            // 
            this.folder_output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.folder_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folder_output.Location = new System.Drawing.Point(277, 61);
            this.folder_output.MaximumSize = new System.Drawing.Size(10000, 50);
            this.folder_output.Name = "folder_output";
            this.folder_output.Size = new System.Drawing.Size(138, 34);
            this.folder_output.TabIndex = 5;
            this.folder_output.Text = "Folder Output";
            this.folder_output.Click += new System.EventHandler(this.folder_output_Click);
            // 
            // view_timetables
            // 
            this.view_timetables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.view_timetables.Location = new System.Drawing.Point(277, 122);
            this.view_timetables.MaximumSize = new System.Drawing.Size(10000, 50);
            this.view_timetables.Name = "view_timetables";
            this.view_timetables.Size = new System.Drawing.Size(138, 37);
            this.view_timetables.TabIndex = 6;
            this.view_timetables.Text = "View Timetables";
            this.view_timetables.UseVisualStyleBackColor = true;
            this.view_timetables.Click += new System.EventHandler(this.view_timetables_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_Button.Location = new System.Drawing.Point(257, 276);
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
            this.Save_file.Location = new System.Drawing.Point(480, 235);
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
            this.Load_Button.Location = new System.Drawing.Point(480, 276);
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
            this.Save_text.Location = new System.Drawing.Point(257, 241);
            this.Save_text.MaximumSize = new System.Drawing.Size(200, 50);
            this.Save_text.Name = "Save_text";
            this.Save_text.Size = new System.Drawing.Size(200, 31);
            this.Save_text.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 213);
            this.label2.MaximumSize = new System.Drawing.Size(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Save Name";
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save_text);
            this.Controls.Add(this.Save_file);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.view_timetables);
            this.Controls.Add(this.folder_output);
            this.Controls.Add(this.generate);
            this.MinimumSize = new System.Drawing.Size(972, 558);
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label folder_output;
        private System.Windows.Forms.Button view_timetables;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label Save_file;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.TextBox Save_text;
        private System.Windows.Forms.Label label2;
    }
}