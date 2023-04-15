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
                int a = int.Parse(textBox1.Text);
                int cnt = 0;

                   if (a >= 1)
                   {
                       for (int i = 1; i <= a; i++)
                       {
                          if (a % i == 0)
                          {
                              cnt++;
                          }
                          if (cnt == 2)
                          {
                              label2.Text = a + " 는 소수입니다";
                          }
                          else
                          {
                              label2.Text = a + " 는 소수가 아닙니다";
                          }

                       }
                   }
                   else
                   {
                       label2.Text = "다른 수를 입력해주세요";
                   }
            }
            catch (Exception ex)
            {


                label2.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
