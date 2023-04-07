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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ulong udata01 = ulong.Parse(textBox1.Text);
                ulong udata02 = ulong.Parse(textBox2.Text);
                ulong sum=0;
                ulong mul = 1;

                for (ulong i = udata01; i <= udata02; i++)
                {
                    mul *= i;
                    sum += i;
                }

                label3.Text = udata01 + "부터" + udata02 + "까지의 합은" + sum + ", 곱은" + mul + "입니다";

               

                if (udata01 >= udata02)
                {
                    label3.Text = "시작값은 마지막값보다 작은 값이어야합니다!";
                }
                else if (udata02 > 20)
                {
                    label3.Text = "마지막값은 21보다 작은 값이어야합니다!";
                }
                
            }
            catch (Exception ex)
            {

                if (textBox1.Text == "")
                {
                    label3.Text = "시작값을 입력하세요";
                }
                else if (textBox2.Text == "")
                {
                    label3.Text = "마지막값을 입력하세요";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
