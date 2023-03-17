
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
            this.Save_Button = new System.Windows.Forms.Button();
            this.Save_file = new System.Windows.Forms.Label();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Save_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Folder_text = new System.Windows.Forms.Label();
            this.view_timetables = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(250)))), ((int)(((byte)(227)))));
            this.generate.FlatAppearance.BorderSize = 0;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generate.ForeColor = System.Drawing.Color.Black;
            this.generate.Location = new System.Drawing.Point(253, 297);
            this.generate.MaximumSize = new System.Drawing.Size(138, 43);
            this.generate.MinimumSize = new System.Drawing.Size(138, 43);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(138, 43);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // folder_output
            // 
            this.folder_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.folder_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folder_output.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folder_output.Location = new System.Drawing.Point(82, 242);
            this.folder_output.MaximumSize = new System.Drawing.Size(309, 34);
            this.folder_output.MinimumSize = new System.Drawing.Size(309, 34);
            this.folder_output.Name = "folder_output";
            this.folder_output.Size = new System.Drawing.Size(309, 34);
            this.folder_output.TabIndex = 5;
            this.folder_output.Text = "Folder Output";
            this.folder_output.Click += new System.EventHandler(this.folder_output_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(250)))), ((int)(((byte)(227)))));
            this.Save_Button.FlatAppearance.BorderSize = 0;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save_Button.ForeColor = System.Drawing.Color.Black;
            this.Save_Button.Location = new System.Drawing.Point(597, 246);
            this.Save_Button.MaximumSize = new System.Drawing.Size(423, 37);
            this.Save_Button.MinimumSize = new System.Drawing.Size(423, 37);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(423, 37);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Save_file
            // 
            this.Save_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Save_file.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_file.Location = new System.Drawing.Point(597, 315);
            this.Save_file.MaximumSize = new System.Drawing.Size(200, 37);
            this.Save_file.MinimumSize = new System.Drawing.Size(200, 37);
            this.Save_file.Name = "Save_file";
            this.Save_file.Size = new System.Drawing.Size(200, 37);
            this.Save_file.TabIndex = 10;
            this.Save_file.Text = "Save File";
            this.Save_file.Click += new System.EventHandler(this.Save_file_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(250)))), ((int)(((byte)(227)))));
            this.Load_Button.FlatAppearance.BorderSize = 0;
            this.Load_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Load_Button.ForeColor = System.Drawing.Color.Black;
            this.Load_Button.Location = new System.Drawing.Point(597, 372);
            this.Load_Button.MaximumSize = new System.Drawing.Size(200, 37);
            this.Load_Button.MinimumSize = new System.Drawing.Size(200, 37);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(200, 37);
            this.Load_Button.TabIndex = 9;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = false;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Save_text
            // 
            this.Save_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_text.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_text.Location = new System.Drawing.Point(597, 209);
            this.Save_text.MaximumSize = new System.Drawing.Size(200, 28);
            this.Save_text.MinimumSize = new System.Drawing.Size(200, 28);
            this.Save_text.Name = "Save_text";
            this.Save_text.Size = new System.Drawing.Size(200, 28);
            this.Save_text.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(643, 181);
            this.label2.MaximumSize = new System.Drawing.Size(103, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Save Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(165, 177);
            this.label1.MaximumSize = new System.Drawing.Size(122, 21);
            this.label1.MinimumSize = new System.Drawing.Size(122, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Output Tables";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(731, 138);
            this.label3.MaximumSize = new System.Drawing.Size(155, 21);
            this.label3.MinimumSize = new System.Drawing.Size(155, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Load/Create Save";
            // 
            // Folder_text
            // 
            this.Folder_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Folder_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Folder_text.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Folder_text.Location = new System.Drawing.Point(820, 203);
            this.Folder_text.MaximumSize = new System.Drawing.Size(200, 37);
            this.Folder_text.MinimumSize = new System.Drawing.Size(200, 37);
            this.Folder_text.Name = "Folder_text";
            this.Folder_text.Size = new System.Drawing.Size(200, 37);
            this.Folder_text.TabIndex = 15;
            this.Folder_text.Text = "Save Folder";
            this.Folder_text.Click += new System.EventHandler(this.Folder_text_Click);
            // 
            // view_timetables
            // 
            this.view_timetables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.view_timetables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(250)))), ((int)(((byte)(227)))));
            this.view_timetables.FlatAppearance.BorderSize = 0;
            this.view_timetables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_timetables.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.view_timetables.ForeColor = System.Drawing.Color.Black;
            this.view_timetables.Location = new System.Drawing.Point(82, 297);
            this.view_timetables.MaximumSize = new System.Drawing.Size(138, 43);
            this.view_timetables.MinimumSize = new System.Drawing.Size(138, 43);
            this.view_timetables.Name = "view_timetables";
            this.view_timetables.Size = new System.Drawing.Size(138, 43);
            this.view_timetables.TabIndex = 16;
            this.view_timetables.Text = "View";
            this.view_timetables.UseVisualStyleBackColor = false;
            this.view_timetables.Click += new System.EventHandler(this.view_timetables_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(493, 1);
            this.panel1.MaximumSize = new System.Drawing.Size(2, 10000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 700);
            this.panel1.TabIndex = 17;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view_timetables);
            this.Controls.Add(this.Folder_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save_text);
            this.Controls.Add(this.Save_file);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Save_Button);
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
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label Save_file;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.TextBox Save_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Folder_text;
        private System.Windows.Forms.Button view_timetables;
        private System.Windows.Forms.Panel panel1;
    }
}