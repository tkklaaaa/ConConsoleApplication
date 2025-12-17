namespace WindowsFormApp.Arrays
{
    partial class Arrays
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
            textBox1 = new TextBox();
            label1 = new Label();
            lblCount = new Label();
            lblSum = new Label();
            lblAverage = new Label();
            button1 = new Button();
            lblMax = new Label();
            lblMin = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 89);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(269, 404);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 45);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 1;
            label1.Text = "กรอกข้อมูลตัวเลข";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblCount.Location = new Point(661, 21);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(227, 31);
            lblCount.TabIndex = 2;
            lblCount.Text = "จำนวนสมาชิกข้อมูล :";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblSum.Location = new Point(733, 66);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(155, 31);
            lblSum.TabIndex = 3;
            lblSum.Text = "ผลรวมข้อมูล :";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblAverage.Location = new Point(724, 116);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(164, 31);
            lblAverage.TabIndex = 4;
            lblAverage.Text = "ค่าเฉลี่ยข้อมูล :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(392, 94);
            button1.Name = "button1";
            button1.Size = new Size(116, 53);
            button1.TabIndex = 5;
            button1.Text = "ประมวลผล";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblMax.Location = new Point(781, 161);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(107, 31);
            lblMax.TabIndex = 6;
            lblMax.Text = "ค่าสูงสุด :";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblMin.Location = new Point(779, 202);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(109, 31);
            lblMin.TabIndex = 7;
            lblMin.Text = "ค่าต่ำสุด :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(609, 253);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(420, 240);
            textBox2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(392, 175);
            button2.Name = "button2";
            button2.Size = new Size(193, 39);
            button2.TabIndex = 9;
            button2.Text = "ข้อมูลใน Array 2 มิติ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(392, 240);
            button3.Name = "button3";
            button3.Size = new Size(193, 64);
            button3.TabIndex = 10;
            button3.Text = "Jagged Array";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Arrays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1062, 564);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(button1);
            Controls.Add(lblAverage);
            Controls.Add(lblSum);
            Controls.Add(lblCount);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = Color.MidnightBlue;
            Name = "Arrays";
            Text = "Arrays";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label lblCount;
        private Label lblSum;
        private Label lblAverage;
        private Button button1;
        private Label lblMax;
        private Label lblMin;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}
