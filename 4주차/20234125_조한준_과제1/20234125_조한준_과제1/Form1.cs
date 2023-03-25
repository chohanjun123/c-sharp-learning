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
                int idata01 = int.Parse(textBox1.Text);
                if (idata01 < 0)
                {
                    textBox2.Text = "음수입니다";
                }
                else if (idata01 < 10)
                {
                    textBox2.Text = "0과 10사이";
                }
                else if (idata01 < 50)
                {
                    textBox2.Text = "10과 50사이";
                }
                else if (idata01 < 100)
                {
                    textBox2.Text = "50과 100사이";
                }
                else if (idata01 >= 100)
                {
                    textBox2.Text = "100이상";
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
