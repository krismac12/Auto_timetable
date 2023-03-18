
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
            this.Classes_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(162)))), ((int)(((byte)(200)))));
            this.Add_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Add_Button.FlatAppearance.BorderSize = 0;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(567, 3);
            this.Add_Button.MinimumSize = new System.Drawing.Size(183, 68);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(183, 68);
            this.Add_Button.TabIndex = 27;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(245, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(551, 234);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Code_Box
            // 
            this.Code_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Code_Box.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Code_Box.Location = new System.Drawing.Point(78, 155);
            this.Code_Box.Name = "Code_Box";
            this.Code_Box.Size = new System.Drawing.Size(150, 30);
            this.Code_Box.TabIndex = 23;
            this.Code_Box.TextChanged += new System.EventHandler(this.Code_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Name_box
            // 
            this.Name_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Name_box.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_box.Location = new System.Drawing.Point(78, 73);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(150, 30);
            this.Name_box.TabIndex = 21;
            this.Name_box.TextChanged += new System.EventHandler(this.Name_box_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(162)))), ((int)(((byte)(200)))));
            this.Delete_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Delete_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(3, 3);
            this.Delete_Button.MinimumSize = new System.Drawing.Size(183, 68);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(183, 68);
            this.Delete_Button.TabIndex = 18;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(162)))), ((int)(((byte)(200)))));
            this.Edit_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Edit_Button.FlatAppearance.BorderSize = 0;
            this.Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit_Button.ForeColor = System.Drawing.Color.White;
            this.Edit_Button.Location = new System.Drawing.Point(191, 3);
            this.Edit_Button.MinimumSize = new System.Drawing.Size(183, 68);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(183, 68);
            this.Edit_Button.TabIndex = 17;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = false;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Classes_button
            // 
            this.Classes_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Classes_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(162)))), ((int)(((byte)(200)))));
            this.Classes_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Classes_button.FlatAppearance.BorderSize = 0;
            this.Classes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Classes_button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Classes_button.ForeColor = System.Drawing.Color.White;
            this.Classes_button.Location = new System.Drawing.Point(379, 3);
            this.Classes_button.MinimumSize = new System.Drawing.Size(183, 68);
            this.Classes_button.Name = "Classes_button";
            this.Classes_button.Size = new System.Drawing.Size(183, 68);
            this.Classes_button.TabIndex = 29;
            this.Classes_button.Text = "Classes";
            this.Classes_button.UseVisualStyleBackColor = false;
            this.Classes_button.Click += new System.EventHandler(this.Classes_button_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.Add_Button, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Classes_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Edit_Button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 74);
            this.tableLayoutPanel1.TabIndex = 30;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Subject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Code_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.label1);
            this.Name = "Subject_Form";
            this.Text = "Subject_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button Classes_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}