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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idata01 = int.Parse(textBox1.Text);

            label1.Text = "결과는" + idata01 + "입니다";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double idata01 = double.Parse(textBox1.Text);

            label1.Text = "결과는" + idata01 + "입니다";
        }

        private void button3_Click(object sender, EventArgs e)
        { int idata01 = int.Parse(textBox1.Text);
            string sdata01 ="332";

            label1.Text = "결과는" + idata01 + "+" + sdata01 + "=" + idata01  + sdata01 + "입니다";
        }
    }
}
