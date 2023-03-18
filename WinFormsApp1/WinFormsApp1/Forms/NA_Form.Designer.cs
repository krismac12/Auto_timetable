
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Type_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.End_num = new System.Windows.Forms.NumericUpDown();
            this.Start_num = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Constraint_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.End_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_num)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // End_Picker
            // 
            this.End_Picker.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.End_Picker.Location = new System.Drawing.Point(131, 171);
            this.End_Picker.Name = "End_Picker";
            this.End_Picker.Size = new System.Drawing.Size(150, 30);
            this.End_Picker.TabIndex = 57;
            this.End_Picker.ValueChanged += new System.EventHandler(this.End_Picker_ValueChanged);
            // 
            // Day_Box
            // 
            this.Day_Box.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Day_Box.FormattingEnabled = true;
            this.Day_Box.Location = new System.Drawing.Point(131, 74);
            this.Day_Box.Name = "Day_Box";
            this.Day_Box.Size = new System.Drawing.Size(151, 31);
            this.Day_Box.TabIndex = 56;
            this.Day_Box.SelectedIndexChanged += new System.EventHandler(this.Day_Box_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Day";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Start_Picker
            // 
            this.Start_Picker.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_Picker.Location = new System.Drawing.Point(131, 125);
            this.Start_Picker.Name = "Start_Picker";
            this.Start_Picker.Size = new System.Drawing.Size(150, 30);
            this.Start_Picker.TabIndex = 54;
            this.Start_Picker.ValueChanged += new System.EventHandler(this.Start_Picker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "End";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(323, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(460, 234);
            this.listBox1.TabIndex = 50;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Start";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Type_box
            // 
            this.Type_box.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Type_box.Location = new System.Drawing.Point(132, 22);
            this.Type_box.Name = "Type_box";
            this.Type_box.Size = new System.Drawing.Size(150, 30);
            this.Type_box.TabIndex = 48;
            this.Type_box.TextChanged += new System.EventHandler(this.Type_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 61;
            this.label7.Text = "End Week";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // End_num
            // 
            this.End_num.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.End_num.Location = new System.Drawing.Point(131, 263);
            this.End_num.Name = "End_num";
            this.End_num.Size = new System.Drawing.Size(151, 30);
            this.End_num.TabIndex = 60;
            this.End_num.ValueChanged += new System.EventHandler(this.End_num_ValueChanged);
            // 
            // Start_num
            // 
            this.Start_num.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_num.Location = new System.Drawing.Point(130, 216);
            this.Start_num.Name = "Start_num";
            this.Start_num.Size = new System.Drawing.Size(151, 30);
            this.Start_num.TabIndex = 59;
            this.Start_num.ValueChanged += new System.EventHandler(this.Start_num_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Start Week";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Constraint_Button, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Delete_Button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Edit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Add_Button, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(33, 319);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(750, 73);
            this.tableLayoutPanel2.TabIndex = 62;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Constraint_Button
            // 
            this.Constraint_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Constraint_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.Constraint_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Constraint_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Constraint_Button.ForeColor = System.Drawing.Color.White;
            this.Constraint_Button.Location = new System.Drawing.Point(564, 3);
            this.Constraint_Button.MinimumSize = new System.Drawing.Size(183, 68);
            this.Constraint_Button.Name = "Constraint_Button";
            this.Constraint_Button.Size = new System.Drawing.Size(183, 68);
            this.Constraint_Button.TabIndex = 63;
            this.Constraint_Button.Text = "Constraints";
            this.Constraint_Button.UseVisualStyleBackColor = false;
            this.Constraint_Button.Click += new System.EventHandler(this.Constraint_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(3, 3);
            this.Delete_Button.MinimumSize = new System.Drawing.Size(183, 68);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(183, 68);
            this.Delete_Button.TabIndex = 30;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click_1);
            // 
            // Edit
            // 
            this.Edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(190, 3);
            this.Edit.MinimumSize = new System.Drawing.Size(183, 68);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(183, 68);
            this.Edit.TabIndex = 53;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // Add_Button
            // 
            this.Add_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(377, 3);
            this.Add_Button.MinimumSize = new System.Drawing.Size(183, 68);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(183, 68);
            this.Add_Button.TabIndex = 36;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click_1);
            // 
            // NA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 395);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.End_num);
            this.Controls.Add(this.Start_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.End_Picker);
            this.Controls.Add(this.Day_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start_Picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type_box);
            this.Controls.Add(this.label1);
            this.Name = "NA_Form";
            this.Text = "NA_Form";
            ((System.ComponentModel.ISupportInitialize)(this.End_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_num)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker End_Picker;
        private System.Windows.Forms.ComboBox Day_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Start_Picker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Type_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown End_num;
        private System.Windows.Forms.NumericUpDown Start_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Constraint_Button;
    }
}