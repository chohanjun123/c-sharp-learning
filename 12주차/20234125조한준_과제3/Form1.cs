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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text);
            }
            if (checkBox5.Checked == true)
            {
                listBox1.Items.Add(checkBox5.Text);
            }
            if (checkBox6.Checked == true)
            {
                listBox1.Items.Add(checkBox6.Text);
            }
            if (checkBox7.Checked == true)
            {
                listBox1.Items.Add(checkBox7.Text);
            }
        }
    }
}
