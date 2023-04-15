using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125_조한준_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = "";

            if (a >= 2 && a <= 9 && b >= 2 && b <= 9 && a <= b)
            {
                label3.Text = "구구단 " + a + " 부터 " + b + " 단 까지 입니다!!";

                for (int i = a; i <= b; i++)
                {

                    label3.Text += "\n\n";

                    for (int j = 2; j <= 9; j++)
                    {
                        label3.Text += i + " * " + j + " = " + i * j + "\n";
                    }


                }


            }

            else
            {
                if (a > b)
                {
                    label3.Text = "시작값은 마지막값보다 크면 안돼여";
                }
                else
                {
                    label3.Text = "2 부터 9 사이의 값을 넣어주세여";
                }

            }

            }
                catch (Exception ex)
                {

                label3.Text = ex.Message;
                
                }
        }
            
    }
}
