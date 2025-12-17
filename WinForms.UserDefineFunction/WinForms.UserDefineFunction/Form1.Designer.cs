namespace WinForms.UserDefineFunction
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 101);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 34);
            label1.TabIndex = 0;
            label1.Text = "นามสกุล :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 94);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(503, 41);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(769, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 34);
            label2.TabIndex = 2;
            label2.Text = "ไม่ต่ำกว่า 2 ตัวอักษร";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 34);
            label3.TabIndex = 3;
            label3.Text = "ชื่อบัญชีผู้ใช้ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 203);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 34);
            label4.TabIndex = 4;
            label4.Text = "รหัสผ่าน :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(233, 145);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(503, 41);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 196);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(503, 41);
            textBox4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 254);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 34);
            label5.TabIndex = 7;
            label5.Text = "ยืนยันรหัสผ่าน :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(233, 247);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(503, 41);
            textBox5.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(369, 311);
            button1.Name = "button1";
            button1.Size = new Size(228, 51);
            button1.TabIndex = 9;
            button1.Text = "สมัครสมาชิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 43);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(503, 41);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 34);
            label6.TabIndex = 10;
            label6.Text = "ชื่อ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(769, 101);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(190, 34);
            label7.TabIndex = 12;
            label7.Text = "ไม่ต่ำกว่า 2 ตัวอักษร";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(769, 152);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(189, 34);
            label8.TabIndex = 13;
            label8.Text = "มีไม่เกิน 20 ตัวอักษร";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(769, 203);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(190, 34);
            label9.TabIndex = 14;
            label9.Text = "ไม่ต่ำกว่า 8 ตัวอักษร";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 576);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "User Define Function";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
