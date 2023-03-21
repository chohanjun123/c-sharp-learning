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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sdata01 = (textBox1.Text);
            string sdata03 = (textBox3.Text);
            label5.Text = "성명:" + sdata01 + "\n학번:" + sdata03;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sdata02 = (textBox2.Text);
            string sdata04 = (textBox4.Text);
            label6.Text = "유선:" + sdata02 + "\n무선:" + sdata04;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }
    }
}
