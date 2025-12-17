using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinForms.UserDefineFunction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private double CalculateTriangleArea(double height, double length)
        {
            double area = 0.5 * height * length;
            return area;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = 0.0;
            double length = 0.0;
            double triarea = 0.0;

            if (double.TryParse(textBox1.Text, out height) && double.TryParse(textBox2.Text, out length))
            {
                triarea = CalculateTriangleArea(height, length);
                label6.Text = "พื้นที่สามเหลี่ยม = " + triarea.ToString("F2");
            }
        }

        private double CalculateCircleArea(double radius, double pi = 3.14)
        {
            double area = pi * radius * radius;
            return area;
        }

        private double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double redius = 0.0;
            double cirarea = 0.0;
            double circumference = 0.0;

            if (double.TryParse(textBox3.Text, out redius))
            {
                cirarea = CalculateCircleArea(redius);
                cirarea = CalculateCircleArea(redius, 3.142);
                circumference = CalculateCircumference(redius);
                label9.Text = "พื้นที่วงกลม = " + cirarea.ToString("F2");
                label15.Text = "เส้นรอบวง = " + circumference.ToString("F2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(textBox4.Text, out i))
            {
                label19.Text = i.ToString();
                label20.Text = RandomNumber(ref i).ToString();
                textBox4.Text = i.ToString();
            }
        }

        private object RandomNumber(ref int x)
        {
            Random rnd = new Random();
            x += rnd.Next(1, 100);
            return x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sum = 0.0;
            string[] inputs = textBox5.Lines;
            double[] number = new double[inputs.Length];
            // วนรอบเพื่อแปลงค่าจาก string เป็น double
            for (int i = 0; i < inputs.Length; i++)
            {
                // If parsing fails set 0; previously code set parsed values to 0 which made the sum always 0
                if (!double.TryParse(inputs[i], out number[i]))
                {
                    number[i] = 0.0;
                }
            }

            sum = CalculateSum(number);

            MessageBox.Show("ผลรวม = " + sum.ToString("F2"));
        }

        private double CalculateSum(double[] nums)
        {
            double total = 0.0;
            foreach (double n in nums)
            {
                total += n;
            }
            return total;
        }
    }
}
