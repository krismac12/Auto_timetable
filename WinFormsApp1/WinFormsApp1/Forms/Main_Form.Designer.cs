
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
            this.OutputButton = new System.Windows.Forms.Button();
            this.Grade_Calc_Button = new System.Windows.Forms.Button();
            this.available_times = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.Button();
            this.subjects = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Home_Button = new System.Windows.Forms.Button();
            this.Page_Label = new System.Windows.Forms.Label();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.OutputButton);
            this.panel1.Controls.Add(this.Grade_Calc_Button);
            this.panel1.Controls.Add(this.available_times);
            this.panel1.Controls.Add(this.classes);
            this.panel1.Controls.Add(this.subjects);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(176, 531);
            this.panel1.TabIndex = 14;
            // 
            // OutputButton
            // 
            this.OutputButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.OutputButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputButton.FlatAppearance.BorderSize = 0;
            this.OutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputButton.Image = ((System.Drawing.Image)(resources.GetObject("OutputButton.Image")));
            this.OutputButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OutputButton.Location = new System.Drawing.Point(0, 272);
            this.OutputButton.Margin = new System.Windows.Forms.Padding(2);
            this.OutputButton.MaximumSize = new System.Drawing.Size(800, 8000);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(176, 48);
            this.OutputButton.TabIndex = 4;
            this.OutputButton.Text = "   Output";
            this.OutputButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OutputButton.UseVisualStyleBackColor = false;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // Grade_Calc_Button
            // 
            this.Grade_Calc_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.Grade_Calc_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grade_Calc_Button.FlatAppearance.BorderSize = 0;
            this.Grade_Calc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grade_Calc_Button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Grade_Calc_Button.Image = ((System.Drawing.Image)(resources.GetObject("Grade_Calc_Button.Image")));
            this.Grade_Calc_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Grade_Calc_Button.Location = new System.Drawing.Point(0, 224);
            this.Grade_Calc_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Grade_Calc_Button.MaximumSize = new System.Drawing.Size(800, 8000);
            this.Grade_Calc_Button.Name = "Grade_Calc_Button";
            this.Grade_Calc_Button.Size = new System.Drawing.Size(176, 48);
            this.Grade_Calc_Button.TabIndex = 3;
            this.Grade_Calc_Button.Text = "   Grade Calculator";
            this.Grade_Calc_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Grade_Calc_Button.UseVisualStyleBackColor = false;
            this.Grade_Calc_Button.Click += new System.EventHandler(this.Grade_Calc_Button_Click);
            // 
            // available_times
            // 
            this.available_times.Dock = System.Windows.Forms.DockStyle.Top;
            this.available_times.FlatAppearance.BorderSize = 0;
            this.available_times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.available_times.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.available_times.Image = ((System.Drawing.Image)(resources.GetObject("available_times.Image")));
            this.available_times.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.available_times.Location = new System.Drawing.Point(0, 176);
            this.available_times.Margin = new System.Windows.Forms.Padding(2);
            this.available_times.MaximumSize = new System.Drawing.Size(800, 8000);
            this.available_times.Name = "available_times";
            this.available_times.Size = new System.Drawing.Size(176, 48);
            this.available_times.TabIndex = 2;
            this.available_times.Text = "   N/A Times";
            this.available_times.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.available_times.UseVisualStyleBackColor = true;
            this.available_times.Click += new System.EventHandler(this.available_times_Click_1);
            // 
            // classes
            // 
            this.classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.classes.Dock = System.Windows.Forms.DockStyle.Top;
            this.classes.FlatAppearance.BorderSize = 0;
            this.classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classes.Image = ((System.Drawing.Image)(resources.GetObject("classes.Image")));
            this.classes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classes.Location = new System.Drawing.Point(0, 128);
            this.classes.Margin = new System.Windows.Forms.Padding(2);
            this.classes.MaximumSize = new System.Drawing.Size(800, 800);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(176, 48);
            this.classes.TabIndex = 1;
            this.classes.Text = "   Classes";
            this.classes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.classes.UseVisualStyleBackColor = false;
            this.classes.Click += new System.EventHandler(this.classes_Click_1);
            // 
            // subjects
            // 
            this.subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.subjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjects.FlatAppearance.BorderSize = 0;
            this.subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjects.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjects.ForeColor = System.Drawing.Color.Gainsboro;
            this.subjects.Image = global::WinFormsApp1.Properties.Resources.Book__1_;
            this.subjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjects.Location = new System.Drawing.Point(0, 80);
            this.subjects.Margin = new System.Windows.Forms.Padding(2);
            this.subjects.MaximumSize = new System.Drawing.Size(800, 8000);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(176, 48);
            this.subjects.TabIndex = 0;
            this.subjects.Text = "   Subjects";
            this.subjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subjects.UseMnemonic = false;
            this.subjects.UseVisualStyleBackColor = false;
            this.subjects.Click += new System.EventHandler(this.subjects_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 80);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Image = global::WinFormsApp1.Properties.Resources.logo__2_w_trans;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 80);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.Home_Button);
            this.panel3.Controls.Add(this.Page_Label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(176, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 80);
            this.panel3.TabIndex = 4;
            // 
            // Home_Button
            // 
            this.Home_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Home_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.Home_Button.FlatAppearance.BorderSize = 0;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.Location = new System.Drawing.Point(0, 0);
            this.Home_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Home_Button.MaximumSize = new System.Drawing.Size(800, 8000);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(90, 80);
            this.Home_Button.TabIndex = 4;
            this.Home_Button.UseVisualStyleBackColor = false;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Page_Label
            // 
            this.Page_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page_Label.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Page_Label.Location = new System.Drawing.Point(0, 0);
            this.Page_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Page_Label.Name = "Page_Label";
            this.Page_Label.Size = new System.Drawing.Size(830, 80);
            this.Page_Label.TabIndex = 5;
            this.Page_Label.Text = "Home";
            this.Page_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.Controls.Add(this.label3);
            this.Main_Panel.Location = new System.Drawing.Point(176, 80);
            this.Main_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(830, 451);
            this.Main_Panel.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(830, 451);
            this.label3.TabIndex = 3;
            // 
            // Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1006, 531);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1028, 587);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Grade_Calc_Button;
        public System.Windows.Forms.Button available_times;
        public System.Windows.Forms.Button classes;
        public System.Windows.Forms.Button subjects;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel Main_Panel;
        public System.Windows.Forms.Button Home_Button;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button OutputButton;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Page_Label;
    }
}