using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125조한준_과제3
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
                string str1 = "홍길동,이순신;임꺽정 세종대왕";
                string str2 = ";, ";
                string[] str;
                string[] str3;
                str = str1.Split(str2.ToCharArray());
                str3 = str1.Split(str2.ToCharArray(),3);

                label1.Text = str[0];
                label2.Text = str[1];
                label3.Text = str[2];
                label4.Text = str[3];

                label5.Text = str3[0];
                label6.Text = str3[1];
                label7.Text = str3[2];
            }
            catch
            {

            }
        }
    }
}
