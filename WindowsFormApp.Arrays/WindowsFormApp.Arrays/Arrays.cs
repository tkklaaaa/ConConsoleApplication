namespace WindowsFormApp.Arrays
{
    public partial class Arrays : Form
    {
        public Arrays()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines; // เก็บข้อมูลแต่ละบรรทัดใน TextBox

            int sum = 0;
            int count = 0;

            int max = int.MinValue;
            int min = int.MaxValue;
            bool any = false;

            for (int i = 0; i < data.Length; i++)
            {
                string line = data[i]?.Trim(); // ตัดช่องว่างรอบๆ ข้อความ
                if (string.IsNullOrWhiteSpace(line)) // ตรวจสอบบรรทัดว่าง isNullOrWhiteSpace คือการตรวจสอบว่าข้อความเป็น null หรือว่างเปล่า หรือมีแต่ช่องว่าง
                {
                    // ข้ามบรรทัดว่าง
                    continue;
                }

                count++;

                int valueForCalc;// ตัวแปรเก็บค่าที่จะใช้ในการคำนวณ
                if (int.TryParse(line, out int number))
                {
                    valueForCalc = number;
                    sum += number;
                }
                else
                {
                    // ถ้าไม่ใช่ตัวเลข ให้เพิ่ม 0 (ยังคงนับเป็นสมาชิก)
                    valueForCalc = 0;
                    sum += 0;
                }

                if (!any)// ถ้ายังไม่มีค่ามาก่อน
                {
                    max = valueForCalc; // กำหนดค่าเริ่มต้น
                    min = valueForCalc; // กำหนดค่าเริ่มต้น
                    any = true;
                }
                else
                {
                    if (valueForCalc > max) max = valueForCalc; // อัปเดตค่าสูงสุด
                    if (valueForCalc < min) min = valueForCalc; // อัปเดตค่าต่ำสุด
                }
            }
            // count > 0 เพื่อป้องกันการหารด้วยศูนย์ ? แทน if-else
            double average = count > 0 ? (double)sum / count : 0;

            // แสดงผลลัพธ์
            lblCount.Text = "จำนวนสมาชิกข้อมูล : " + count;
            lblSum.Text = "ผลรวมข้อมูล : " + sum;
            lblAverage.Text = count > 0 ? "ค่าเฉลี่ยข้อมูล : " + average : "ค่าเฉลี่ยข้อมูล : N/A";

            lblMax.Text = any ? "ค่าสูงสุด : " + max : "ค่าสูงสุด : N/A";
            lblMin.Text = any ? "ค่าต่ำสุด : " + min : "ค่าต่ำสุด : N/A";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] data = new string[5, 3]
               {
                    {"ธันวา", "ท็อป" , "หนองคาย"},
                    {"ณัฐภูมิ", "น็อต", "หนองคาย" },
                    {"วัชชิระ", "สเน็ค", "อุดรธานี" },
                    {"ภุริณัฐ", "ทีนนี่", "อุดรธานี" },
                    {"อินทิรา", "เอ้มมี่", "หนองคาย" }
               };
            int rows = data.GetLength(0); // จำนวนแถว
                                          // int cols = data.GetLength(1); // จำนวนคอลัมน์
            string result = ""; // เก็บผลลัพธ์
            for (int i = 0; i < rows; i++)
            {
                result += "ข้อมูลที่ " + (i + 1) + " \n ";
                result += "ชื่อจริง : " + data[i, 0] + ", ";
                result += "ชื่อเล่น : " + data[i, 1] + ", ";
                result += "จังหวัด : " + data[i, 2] + Environment.NewLine;
            }

            MessageBox.Show(result, "ข้อมูลใน Array 2 มิติ ");
            textBox2.AppendText(result + Environment.NewLine);

        }
    }
}
