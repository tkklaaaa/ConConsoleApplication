namespace WinFormsApp_BMI
{
    partial class CalculationBMI
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
            components = new System.ComponentModel.Container();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            lblBMI = new Label();
            lblResult = new Label();
            txtDetail = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            timerButton = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(99, 36);
            txtWeight.Margin = new Padding(4, 3, 4, 3);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(353, 28);
            txtWeight.TabIndex = 0;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(99, 70);
            txtHeight.Margin = new Padding(4, 3, 4, 3);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(353, 28);
            txtHeight.TabIndex = 1;
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Location = new Point(165, 38);
            lblBMI.Margin = new Padding(4, 0, 4, 0);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(42, 21);
            lblBMI.TabIndex = 2;
            lblBMI.Text = "BMI";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(162, 77);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(58, 21);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result";
            // 
            // txtDetail
            // 
            txtDetail.Location = new Point(135, 371);
            txtDetail.Margin = new Padding(4, 3, 4, 3);
            txtDetail.Multiline = true;
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(586, 147);
            txtDetail.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Location = new Point(135, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(582, 171);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "รับค่า";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 74);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 9;
            label5.Text = "ส่วนสูง : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 8;
            label4.Text = "น้ำหนัก : ";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(99, 105);
            btnCalculate.Margin = new Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(354, 42);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate BMI";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblResult);
            groupBox2.Controls.Add(lblBMI);
            groupBox2.Location = new Point(135, 213);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(588, 121);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลการคำนวณ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 5;
            label2.Text = "ผลลัพท์  : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 4;
            label1.Text = "ค่า BMI : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 347);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 7;
            label3.Text = "คำอธิบาย";
            // 
            // timerButton
            // 
            timerButton.Interval = 2000;
            timerButton.Tick += timerButton_Tick;
            // 
            // CalculationBMI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 515);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtDetail);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CalculationBMI";
            Text = "CalculationBMI";
            Load += CalculationBMI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label lblBMI;
        private Label lblResult;
        private TextBox txtDetail;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCalculate;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private System.Windows.Forms.Timer timerButton;
    }
}
