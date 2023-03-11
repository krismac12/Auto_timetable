
namespace WinFormsApp1
{
    partial class Class_Form
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
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Code_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subject_Box = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.Subject_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Edit_Button
            // 
            this.Edit_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit_Button.ForeColor = System.Drawing.Color.White;
            this.Edit_Button.Location = new System.Drawing.Point(228, 3);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(212, 41);
            this.Edit_Button.TabIndex = 1;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = false;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(5, 3);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(212, 41);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Code_Box
            // 
            this.Code_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Code_Box.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Code_Box.Location = new System.Drawing.Point(90, 244);
            this.Code_Box.MaximumSize = new System.Drawing.Size(1000, 50);
            this.Code_Box.Name = "Code_Box";
            this.Code_Box.Size = new System.Drawing.Size(150, 30);
            this.Code_Box.TabIndex = 7;
            this.Code_Box.TextChanged += new System.EventHandler(this.Code_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subject";
            // 
            // Subject_Box
            // 
            this.Subject_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Subject_Box.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subject_Box.FormattingEnabled = true;
            this.Subject_Box.Location = new System.Drawing.Point(90, 192);
            this.Subject_Box.MaximumSize = new System.Drawing.Size(1000, 0);
            this.Subject_Box.Name = "Subject_Box";
            this.Subject_Box.Size = new System.Drawing.Size(150, 31);
            this.Subject_Box.TabIndex = 13;
            this.Subject_Box.SelectedIndexChanged += new System.EventHandler(this.Subject_Box_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(301, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 326);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(676, 3);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(212, 41);
            this.Add_Button.TabIndex = 15;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(112, 34);
            this.Back_Button.TabIndex = 29;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Times
            // 
            this.Times.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.Times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Times.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Times.ForeColor = System.Drawing.Color.White;
            this.Times.Location = new System.Drawing.Point(451, 3);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(212, 41);
            this.Times.TabIndex = 30;
            this.Times.Text = "Times";
            this.Times.UseVisualStyleBackColor = false;
            this.Times.Click += new System.EventHandler(this.Times_Click);
            // 
            // Subject_Label
            // 
            this.Subject_Label.AutoSize = true;
            this.Subject_Label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Subject_Label.Location = new System.Drawing.Point(301, 9);
            this.Subject_Label.MaximumSize = new System.Drawing.Size(500, 50);
            this.Subject_Label.Name = "Subject_Label";
            this.Subject_Label.Size = new System.Drawing.Size(61, 23);
            this.Subject_Label.TabIndex = 31;
            this.Subject_Label.Text = "Name";
            this.Subject_Label.Click += new System.EventHandler(this.Subject_Label_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Delete_Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Edit_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Times, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Add_Button, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 420);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 47);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // Name_box
            // 
            this.Name_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Name_box.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_box.Location = new System.Drawing.Point(90, 143);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(150, 30);
            this.Name_box.TabIndex = 33;
            // 
            // Class_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 496);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Subject_Label);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Subject_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Code_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Class_Form";
            this.Text = "subjects_form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Code_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Subject_Box;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Label Subject_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Name_box;
    }
}