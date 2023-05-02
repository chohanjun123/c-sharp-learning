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
        double cnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

        double a = double.Parse(textBox1.Text);
        cnt += a;
        label1.Text = "" + cnt;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            double a = double.Parse(textBox1.Text);
            cnt -= a;
            label1.Text = "" + cnt;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

            double a = double.Parse(textBox1.Text);
            cnt *= a;
            label1.Text = "" + cnt;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

            double a = double.Parse(textBox1.Text);
            cnt /= a;
            label1.Text = "" + cnt;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

            label1.Text = "0";
            cnt = 0;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            
        }

    }
}
