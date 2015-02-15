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

            string a = "00";
            string b = "00";
            string c = "00";
            string d = "00";
            
            if (checkBox1.Checked == false) //不启用小册子
            {

                for (int i = start; i <= page; i++) //单面打印机
                {
                    count.calc(ref a, ref b, ref c, ref d, ref i, ref page);


                    if (checkBox2.Checked == false)//不启用反面逆序算法
                    {
                        textBox1.Text += a + b;
                        textBox2.Text += c + d;
                    }
                    else //启用反面逆序算法
                    {
                        
                        textBox1.Text += a + b ;

                        textBox2.Text = c + d + textBox2.Text;
                    }

                }

                for (int i = start; i <= page; i++) //双面打印机
                {
                    count.calc(ref a, ref b, ref c, ref d, ref i, ref page);

                        textBox3.Text += a + b + d + c;
                }
            }
            else
            {
                for (int i = start; i <= page; i++)//小册子打印机
                {
                    count.calc(ref a, ref b, ref c, ref d, ref i, ref page);
                    textBox3.Text += a + d + c + b; //双面打印机。
                    if (checkBox2.Checked == false)
                    {
                        textBox1.Text += d + a ;

                        textBox2.Text += b + c ;
                    }
                    else
                    {
                        textBox1.Text += d + a  ;

                        textBox2.Text = b + c +textBox2.Text;
                    }

                    




                }
            }

        }
    }
}
