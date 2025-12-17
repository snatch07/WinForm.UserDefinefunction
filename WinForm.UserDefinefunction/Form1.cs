namespace WinForm.UserDefinefunction
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

        private void checkfirstname()
        {
            firstname = textBox1.Text;
            if (string.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("กำหนดชื่อให้ไม่เป็นตัวว่าง");
                textBox1.Focus();
                return;
            }
            if (firstname.Length < 2)
            {
                MessageBox.Show("กำหนดให้ชื่อต้องมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox1.Focus();
            }
        }

        private void checklastname()
        {
            lastname = textBox5.Text;
            if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("กำหนดนามสกุลให้ไม่เป็นตัวว่าง");
                textBox5.Focus();
                return;
            }
            if (lastname.Length < 2)
            {
                MessageBox.Show("กำหนดให้ชื่อต้องมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox5.Focus();
            }
        }

        private void checkusername()
        {
            username = textBox2.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("กำหนดชื่อผู้ใช้ให้ไม่เป็นตัวว่าง");
                textBox2.Focus();
                return;
            }
            if (username.Length > 20)
            {
                MessageBox.Show("กำหนดให้ชื่อผู้ใช้ต้องมีความยาวไม่เกิน 20 ตัวอักษร");
                textBox2.Focus();
            }
        }

        private void checkName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("กำหนดชื่อให้ไม่เป็นตัวว่าง");
                return;
            }
            if (name.Length < 2)
            {
                MessageBox.Show("กำหนดให้ชื่อต้องมีความยาวอย่างน้อย 2 ตัวอักษร");
            }
        }

        private void checkPassword(TextBox Password, TextBox confirmPassword)
        {
            if (string.IsNullOrEmpty(Password.Text) || string.IsNullOrWhiteSpace(confirmPassword.Text))
            {
                MessageBox.Show("กำหนดรหัสผ่านให้ไม่เป็นตัวว่าง");
                textBox3.Focus();
                return;
            }
            if (Password.Text.Length < 8)
            {
                MessageBox.Show("กำหนดให้รหัสผ่านต้องมีความยาวอย่างน้อย 8 ตัวอักษร");
                return;
            }
            if (Password.Text != confirmPassword.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkfirstname();
            //checklastname();
            firstname = textBox1.Text;
            lastname = textBox5.Text;
            checkName(firstname);
            checkName(lastname);
            checkusername();
            checkPassword(textBox3, textBox4);
        }
    }
}
