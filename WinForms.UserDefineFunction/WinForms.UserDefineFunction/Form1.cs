namespace WinForms.UserDefineFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string firstname;
        string lastname;
        string username;
        string password;

        /*
        private void checkfirstname()
        {
            firstname = textBox1.Text;
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("กำหนดชื่อไม่เป็นที่ว่าง.","Warnning!!!!");
                textBox1.Focus();
                return;
            }
            else if (firstname.Length < 2)
            {
                MessageBox.Show("กำหนดให้ชื่อไม่ต่ำกว่า 2 ตัวอักษร.","Warnning!!!!");
                textBox1.Focus();
            }
        }

        private void checklastname()
        {
            lastname = textBox2.Text;
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("กำหนดนามสกุลไม่เป็นที่ว่าง.", "Warnning!!!!");
                textBox2.Focus();
                return;
            }
            else if (lastname.Length < 2)
            {
                MessageBox.Show("กำหนดให้นามสกุลไม่ต่ำกว่า 2 ตัวอักษร.", "Warnning!!!!");
                textBox2.Focus();
            }
        }
        */
        private void Checkusername()
        {
            username = textBox3.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("กำหนดชื่อผู้ใช้ไม่เป็นที่ว่าง.", "Warnning!!!!");
                textBox3.Focus();
                return;
            }
            else if (username.Length > 20)
            {
                MessageBox.Show("กำหนดให้ชื่อผู้ใช้มีความยาวไม่เกิน 20 ตัวอักษร.", "Warnning!!!!");
                textBox3.Focus();
            }
        }

        // ฟังก์ชันตรวจสอบชื่อ
        private void CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("กำหนดชื่อไม่เป็นที่ว่าง.", "Warnning!!!!");
                textBox1.Focus();
                return;
            }
            else if (name.Length < 2)
            {
                MessageBox.Show("กำหนดให้ชื่อไม่ต่ำกว่า 2 ตัวอักษร.", "Warnning!!!!");
                textBox1.Focus();
            }
        }

        private void CheckPassword(TextBox Password,TextBox confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(confirmPassword.Text))
            {   
                if (string.IsNullOrWhiteSpace(Password.Text))
                {
                    MessageBox.Show("กำหนดรหัสผ่านไม่เป็นที่ว่าง.", "Warnning!!!!");
                    Password.Focus();
                }
                else
                {
                    MessageBox.Show("ยืนยันรหัสผ่านไม่เป็นที่ว่าง.", "Warnning!!!!");
                    confirmPassword.Focus();
                }
                return;
            }
            else if (Password.Text.Length < 8)
            {
                MessageBox.Show("กำหนดให้รหัสผ่านมีความยาวไม่น้อยกว่า 8 ตัวอักษร.", "Warnning!!!!");
                Password.Focus();
                return;
            }
            else if (Password.Text != confirmPassword.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน.", "Warnning!!!!");
                confirmPassword.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            checkfirstname();
            checklastname();
            */
            firstname = textBox1.Text;
            lastname = textBox2.Text;
            CheckName(firstname);
            CheckName(lastname);
            Checkusername();
            CheckPassword(textBox4, textBox5);
        }
    }
}
