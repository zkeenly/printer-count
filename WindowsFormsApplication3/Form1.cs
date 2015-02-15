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
            textBox7.Text = "";
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

                        textBox3.Text += a + b + d + c;    //反面逆序。
                        textBox7.Text += a + b + c + d;    //反面正序。
                }
            }



            else                                        //启用小册子。
            { 
                for (int i = start; i <= page; i++)
                {
                    count.calc(ref a, ref b, ref c, ref d, ref i, ref page);
                    
                    textBox7.Text += d + a + b + c; //双面打印机 反面正序。
                    textBox3.Text += d + a + c + b; //双面打印机 反面逆序。


                    if (checkBox2.Checked == false) //单面打印机    反面正序。
                    {
                        textBox1.Text += d + a ;

                        textBox2.Text += b + c ;
                    }
                    else            //反面逆序
                    {
                        textBox1.Text += d + a  ;

                        textBox2.Text = b + c +textBox2.Text;
                    }

                    




                }
            }

        }
    }
}
