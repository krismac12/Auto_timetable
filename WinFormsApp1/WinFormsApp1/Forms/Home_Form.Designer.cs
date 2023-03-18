
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(250)))), ((int)(((byte)(227)))));
            this.generate.FlatAppearance.BorderSize = 0;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generate.ForeColor = System.Drawing.Color.Black;
            this.generate.Location = new System.Drawing.Point(2, 212);
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
            this.folder_output.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.folder_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folder_output.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.folder_output.Location = new System.Drawing.Point(2, 154);
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
            this.Save_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(250)))), ((int)(((byte)(227)))));
            this.Save_Button.FlatAppearance.BorderSize = 0;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save_Button.ForeColor = System.Drawing.Color.Black;
            this.Save_Button.Location = new System.Drawing.Point(42, 196);
            this.Save_Button.MaximumSize = new System.Drawing.Size(423, 37);
            this.Save_Button.MinimumSize = new System.Drawing.Size(309, 37);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(395, 37);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Save_file
            // 
            this.Save_file.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Save_file.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_file.Location = new System.Drawing.Point(42, 252);
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
            this.Load_Button.Location = new System.Drawing.Point(42, 305);
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
            this.Save_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save_text.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_text.Location = new System.Drawing.Point(42, 157);
            this.Save_text.MaximumSize = new System.Drawing.Size(200, 28);
            this.Save_text.MinimumSize = new System.Drawing.Size(150, 28);
            this.Save_text.Name = "Save_text";
            this.Save_text.Size = new System.Drawing.Size(172, 28);
            this.Save_text.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 133);
            this.label2.MaximumSize = new System.Drawing.Size(103, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Save Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 75);
            this.label1.MaximumSize = new System.Drawing.Size(122, 21);
            this.label1.MinimumSize = new System.Drawing.Size(122, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Output Tables";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(145, 69);
            this.label3.MaximumSize = new System.Drawing.Size(155, 21);
            this.label3.MinimumSize = new System.Drawing.Size(155, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Load/Create Save";
            // 
            // Folder_text
            // 
            this.Folder_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Folder_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Folder_text.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Folder_text.Location = new System.Drawing.Point(237, 148);
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
            this.view_timetables.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.view_timetables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(250)))), ((int)(((byte)(227)))));
            this.view_timetables.FlatAppearance.BorderSize = 0;
            this.view_timetables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_timetables.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.view_timetables.ForeColor = System.Drawing.Color.Black;
            this.view_timetables.Location = new System.Drawing.Point(162, 212);
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
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(317, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(2, 10000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 389);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.generate);
            this.panel2.Controls.Add(this.view_timetables);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.folder_output);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 389);
            this.panel2.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 395);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.Folder_text);
            this.panel3.Controls.Add(this.Load_Button);
            this.panel3.Controls.Add(this.Save_file);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Save_text);
            this.panel3.Controls.Add(this.Save_Button);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(326, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 389);
            this.panel3.TabIndex = 20;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(830, 451);
            this.Name = "Home_Form";
            this.Text = "Home_Form";
            this.Load += new System.EventHandler(this.Home_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
    }
}