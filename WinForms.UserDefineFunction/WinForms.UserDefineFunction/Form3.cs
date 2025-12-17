using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.UserDefineFunction
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letter = (string)textBox1.Text;
            int size = int.Parse(textBox2.Text);
            //if (radioButton1.Checked)
            //{
            //    //ส่งค่าปกติ
            //    textBox3.Text = Triabgle1(letter, size);
            //}
            //else if (radioButton2.Checked)
            //{
            //    //ส่งค่าแบบ Optional กำหนดค่าเริ่มต้น size 5 
            //    textBox3.Text = Triabgle2(letter);
            //}
            //else if (radioButton3.Checked)
            //{
            //    //ส่งค่าแบบ out
            //    Triabgle3(letter, out string result);
            //}

        }
    }
}
