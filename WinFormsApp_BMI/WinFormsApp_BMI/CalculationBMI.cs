namespace WinFormsApp_BMI
{
    public partial class CalculationBMI : Form
    {
        public CalculationBMI()
        {
            InitializeComponent();
        }
        private Color defaultColor; // สีเริ่ม
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            defaultColor = btnCalculate.BackColor;

            // ------------------------------
            // โค้ดคำนวณ BMI 
            // ------------------------------

            double weight, height;

            // trypharse แปลงข้อความเป็นตัวเลขแบบปลอดภัย
            if (!double.TryParse(txtWeight.Text, out weight) ||
                !double.TryParse(txtHeight.Text, out height))
            {
                btnCalculate.BackColor = Color.Red;
                MessageBox.Show("กรุณากรอกตัวเลขให้ถูกต้อง");

                timerButton.Start();
                return;
            }

            btnCalculate.BackColor = Color.Green;
            timerButton.Start();   // เริ่มจับเวลา 2 วินาที

            double h = height / 100.0;
            double bmi = weight / (h * h);
            lblBMI.Text = bmi.ToString("0.00");

            string result = "";
            string detail = "";

            if (bmi < 18.5)
            {
                result = "ผอมเกินไป";
                detail =
                    "ผอมเกินไป = น้อยกว่า 18.5\r\nน้ำหนักน้อยกว่าปกติก็ไม่ค่อยดี หากคุณสูงมากแต่น้ำหนักน้อยเกินไป อาจเสี่ยงต่อการได้รับสารอาหารไม่เพียงพอหรือได้รับพลังงานไม่เพียงพอ ส่งผลให้ร่างกายอ่อนเพลียง่าย การรับประทานอาหารให้เพียงพอ และการออกกำลังกายเพื่อเสริมสร้างกล้ามเนื้อสามารถช่วยเพิ่มค่า BMI ให้อยู่ในเกณฑ์ปกติได้";
            }
            else if (bmi >= 18.6 && bmi <= 24)
            {
                result = "น้ำหนักปกติ เหมาะสม";
                detail =
                    "น้ำหนักปกติ เหมาะสม = 18.6 - 24\r\nน้ำหนักที่เหมาะสมสำหรับคนไทยคือค่า BMI ระหว่าง 18.5-24 จัดอยู่ในเกณฑ์ปกติ ห่างไกลโรคที่เกิดจากความอ้วน และมีความเสี่ยงต่อการเกิดโรคต่าง ๆ น้อยที่สุด ควรพยายามรักษาระดับค่า BMI ให้อยู่ในระดับนี้ให้นานที่สุด และควรตรวจสุขภาพทุกปี";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                result = "อ้วน";
                detail =
                    "อ้วน = 25.0 - 29.9\r\nอ้วนในระดับหนึ่ง ถึงแม้จะไม่ถึงเกณฑ์ที่ถือว่าอ้วนมาก ๆ แต่ก็ยังมีความเสี่ยงต่อการเกิดโรคที่มากับความอ้วนได้เช่นกัน ทั้งโรคเบาหวาน และความดันโลหิตสูง ควรปรับพฤติกรรมการทานอาหาร ออกกำลังกาย และตรวจสุขภาพ";
            }
            else if (bmi >= 30)
            {
                result = "อ้วนมาก";
                detail =
                    "อ้วนมาก = 30.0 ขึ้นไป\r\nค่อนข้างอันตราย เสี่ยงต่อการเกิดโรคร้ายแรงที่แฝงมากับความอ้วน หากค่า BMI อยู่ในระดับนี้ จะต้องปรับพฤติกรรมการทานอาหาร และควรเริ่มออกกำลังกาย และหากเลขยิ่งสูงกว่า 40.0 ยิ่งแสดงถึงความอ้วนที่มากขึ้น ควรไปตรวจสุขภาพ และปรึกษาแพทย์";
            }

            lblResult.Text = result;
            txtDetail.Text = detail;
        }

        private void timerButton_Tick(object sender, EventArgs e)
        {
            btnCalculate.BackColor = defaultColor;

            // ปิด timer
            timerButton.Stop();
        }

        private void CalculationBMI_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
             "ยินดีต้อนรับสู่โปรแกรมคำนวณ BMI\n",
                "Welcome",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information
            );
        }
    }
}
