using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.UserDefinefunction
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
            int type = 1;
            if (radioButton1.Checked)
            {
                type = 1;
                //textBox3.Text = Triangle1(letter, size);
            }
            else if (radioButton2.Checked)
            {
                type = 2;
                //textBox3.Text = Triangle2(letter);
            }
            else if (radioButton3.Checked)
            {
                type = 3;
                //Triangle3(letter, size, out string result);
            }
        }
    }
}
