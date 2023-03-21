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

        private void button1_Click(object sender, EventArgs e)
        {
            string sdata01 = "20234125";
            string sdata02 = "조한준";

            label1.Text = "성명:" + sdata02 + "\n학번:" + sdata01;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sdata01 = "055-1234-5678";
            string sdata02 = "010-5190-4965";

            label2.Text = "유선:" + sdata01 + "\n무선:" + sdata02;
        }
    }
}
