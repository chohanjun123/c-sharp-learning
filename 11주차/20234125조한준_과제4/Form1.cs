using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125조한준_과제4
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
                int num = 12345;
                string str1 = string.Format("{0:C}", num);
                label1.Text = "귀하의 잔액은 " + str1 + "입니다!!";

                int iNum = 12345;
                    double dNum = 0.05;
                string str2 = string.Format("{0:C}이고, 재산순위 상위 {1:P1}", iNum, dNum);
                label2.Text = "귀화의 계좌총액은 " + str2 + "입니다!!";
            }
            catch
            {

            }
        }
    }
}
