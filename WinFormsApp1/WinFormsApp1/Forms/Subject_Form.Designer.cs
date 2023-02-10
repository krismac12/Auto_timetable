
namespace WinFormsApp1
{
    partial class Subject_Form
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Code_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Classes_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_Button.Location = new System.Drawing.Point(439, 357);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(112, 34);
            this.Add_Button.TabIndex = 27;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(247, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 229);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Code_Box
            // 
            this.Code_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Code_Box.Location = new System.Drawing.Point(587, 85);
            this.Code_Box.Name = "Code_Box";
            this.Code_Box.Size = new System.Drawing.Size(150, 31);
            this.Code_Box.TabIndex = 23;
            this.Code_Box.TextChanged += new System.EventHandler(this.Code_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Code";
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(307, 85);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(150, 31);
            this.Name_box.TabIndex = 21;
            this.Name_box.TextChanged += new System.EventHandler(this.Name_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Delete_Button.Location = new System.Drawing.Point(65, 141);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(112, 34);
            this.Delete_Button.TabIndex = 18;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Edit_Button.Location = new System.Drawing.Point(65, 239);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(112, 34);
            this.Edit_Button.TabIndex = 17;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(112, 34);
            this.Back_Button.TabIndex = 28;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Classes_button
            // 
            this.Classes_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Classes_button.Location = new System.Drawing.Point(65, 341);
            this.Classes_button.Name = "Classes_button";
            this.Classes_button.Size = new System.Drawing.Size(112, 34);
            this.Classes_button.TabIndex = 29;
            this.Classes_button.Text = "Classes";
            this.Classes_button.UseVisualStyleBackColor = true;
            this.Classes_button.Click += new System.EventHandler(this.Classes_button_Click);
            // 
            // Subject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 446);
            this.Controls.Add(this.Classes_button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Code_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Edit_Button);
            this.Name = "Subject_Form";
            this.Text = "Subject_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Code_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Classes_button;
    }
}