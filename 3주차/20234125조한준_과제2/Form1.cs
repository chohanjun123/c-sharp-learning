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
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            int iData02 = int.Parse(textBox2.Text);

            bool bData01 = iData01 == iData02;

            label1.Text = "==";
            label2.Text = "결과는" + bData01 + "입니다.";

        }
    }
}
