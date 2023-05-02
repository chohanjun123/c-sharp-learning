using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125조한준_과제2
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
                int idata01 = int.Parse(textBox1.Text);
                    int sum = 0;

                for(int i = 1; i <= idata01; i++)
                {
                    sum += i;
                }
                cnt += 1;

                label1.Text = "합: " + sum;
                label2.Text = "현재까지 실행 횟수: " + cnt;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
