using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125조한준_과제1
{
    public partial class Form1 : Form
    {

       int cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);

                if(a > 0 && a < 1000)
                {
                    label6.Text = "";
                    cnt += a;
                    label5.Text = "조한준 계좌잔고: " + cnt + "원";
                }
                else
                {
                    label5.Text = "다른 값을 입력해주세요";
                }
            }
            catch(Exception ex)
            {
                label6.Text = ex.Message; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int b = int.Parse(textBox2.Text);

                if (b <= cnt)
                {
                    label6.Text = "";
                    cnt -= b;
                    label5.Text = "조한준 계좌잔고: " + cnt + "원";
                }
                 else
                {
                    label6.Text = "다른 값을 입력해주세요";
                }
            }
            catch (Exception ex)
            {
                label6.Text = ex.Message;
            }
        }
    }
}
