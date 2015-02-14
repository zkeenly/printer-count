using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            int start = Convert.ToInt32(textBox4.Text);
            int page = Convert.ToInt32(textBox5.Text);

            string a = "";
            string b = "";
            string c = "";
            string d = "";
            if (checkBox1.Checked == false)
            {

                for (int i = 1; i <= page; i++)
                {
                    textBox1.Text += i + ",";  //正面
                    textBox1.Text += ++i + ",";

                    textBox2.Text += ++i + ",";  //反面
                    textBox2.Text += ++i + ",";

                }

                for (int i = 1; i <= page; i++)
                {
                    textBox3.Text += i + ",";  //正面
                    textBox3.Text += ++i + ",";

                    b = ++i + ",";  //反面
                    a = ++i + ",";
                    textBox3.Text += a;
                    textBox3.Text += b;

                }
            }
            else
            {
                for (int i = 1; i <= page; i++)
                {
                    a = i + ",";  
                    b = ++i + ",";
                    c = ++i + ",";  
                    d = ++i + ",";

                    textBox1.Text += a + d;
                    textBox2.Text += c + b;
                    




                }
            }

        }
    }
}
