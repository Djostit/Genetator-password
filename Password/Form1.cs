using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class Form1 : Form
    {
        int len;
        string sel;
        public Form1()
        {
            InitializeComponent();
        }
        public string GenPassword()
        {
            string password = "";
            Random rnd = new Random();
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                while (password.Length < len)
                {
                    string a = "";
                    string b = "";
                    string c = "";
                    string st = "";
                    Char gen = (char)rnd.Next(33, 125);
                    if (Char.IsUpper(gen))
                    {
                        a += gen;
                    }
                    if (Char.IsLower(gen))
                    {
                        b += gen;
                    }
                    if(Char.IsDigit(gen))
                    {
                        c += gen;
                    }
                    st += a + b + c;
                    if (st.Contains(a) && st.Contains(b) && st.Contains(c))
                    {
                        password = st;
                    }
                }
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                while (password.Length < len)
                {
                    string a = "";
                    string b = "";
                    Char gen = (char)rnd.Next(33, 125);
                    if (Char.IsUpper(gen))
                    {
                        a += gen;
                    }
                    if (Char.IsLower(gen))
                    {
                        b += gen;
                    }
                    password += a + b;
                }
            }
            if (checkBox1.Checked == true)
            {
                while (password.Length < len)
                {
                    Char gen = (char)rnd.Next(33, 125);
                    if (Char.IsUpper(gen))
                    {
                        password += gen;
                    }
                }
            }
            if (checkBox2.Checked == true)
            {
                while (password.Length < len)
                {
                    Char gen = (char)rnd.Next(33, 125);
                    if (Char.IsLower(gen))
                    {
                        password += gen;
                    }
                }
            }
            if (checkBox3.Checked == true)
            {
                while (password.Length < len)
                {
                    Char gen = (char)rnd.Next(33, 125);
                    if (Char.IsDigit(gen))
                    {
                        password += gen;
                    }
                }
            }
            if (checkBox4.Checked == true)
            {
                while (password.Length < len)
                {
                    Char gen = (char)rnd.Next(33, 125);
                    if (Char.IsSymbol(gen))
                    {
                        password += gen;
                    }
                }
            }
            return password;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GenPassword();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sel += "Upper";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sel += "Lower";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            sel += "Digit";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            sel += "Symbol";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            len = (int)numericUpDown1.Value;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = GenPassword();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                Clipboard.SetText(textBox1.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
