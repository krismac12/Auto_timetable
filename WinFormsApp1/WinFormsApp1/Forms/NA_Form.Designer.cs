﻿
namespace WinFormsApp1
{
    partial class NA_Form
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
            this.End_Picker = new System.Windows.Forms.DateTimePicker();
            this.Day_Box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Start_Picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Type_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // End_Picker
            // 
            this.End_Picker.Location = new System.Drawing.Point(99, 207);
            this.End_Picker.Name = "End_Picker";
            this.End_Picker.Size = new System.Drawing.Size(150, 31);
            this.End_Picker.TabIndex = 57;
            // 
            // Day_Box
            // 
            this.Day_Box.FormattingEnabled = true;
            this.Day_Box.Location = new System.Drawing.Point(99, 133);
            this.Day_Box.Name = "Day_Box";
            this.Day_Box.Size = new System.Drawing.Size(151, 33);
            this.Day_Box.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Day";
            // 
            // Start_Picker
            // 
            this.Start_Picker.Location = new System.Drawing.Point(99, 170);
            this.Start_Picker.Name = "Start_Picker";
            this.Start_Picker.Size = new System.Drawing.Size(150, 31);
            this.Start_Picker.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "End";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(4, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(112, 34);
            this.Back_Button.TabIndex = 52;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(164, 274);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(112, 34);
            this.Add_Button.TabIndex = 51;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(323, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 254);
            this.listBox1.TabIndex = 50;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Start";
            // 
            // Type_box
            // 
            this.Type_box.Location = new System.Drawing.Point(99, 96);
            this.Type_box.Name = "Type_box";
            this.Type_box.Size = new System.Drawing.Size(150, 31);
            this.Type_box.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Type";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(33, 274);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(112, 34);
            this.Delete_Button.TabIndex = 46;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // NA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 344);
            this.Controls.Add(this.End_Picker);
            this.Controls.Add(this.Day_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start_Picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_Button);
            this.Name = "NA_Form";
            this.Text = "NA_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker End_Picker;
        private System.Windows.Forms.ComboBox Day_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Start_Picker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Type_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_Button;
    }
}