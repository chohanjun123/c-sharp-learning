using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125_조한준_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata01 = int.Parse(textBox1.Text);
                double ddata01 = double.Parse(textBox2.Text);

              
                {
                
                }
                if (idata01 == 1)
                {
                    double result = ddata01 * 3.28;
                    textBox3.Text = "결과는" + result;
                    label6.Text = "feet";
                }
                else if (idata01 == 2)
                {
                    double result = ddata01 / 3.28;
                    textBox3.Text = "결과는" + result;
                    label6.Text = "meter";
                }
                else 
                {
                    textBox1.Text="1 또는 2를 입력하세요";
                   
                }
            
            }
            catch (Exception ex)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "1 또는 2를 입력하세요";
                }
                else if (textBox2.Text == "")
                {
                    textBox2.Text = "환산할 수를 입력하세요!";
                }
                else if (textBox3.Text == "")
                {
                    textBox3.Text = ex.Message;
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label6.Text = "";
        }
    }
}
