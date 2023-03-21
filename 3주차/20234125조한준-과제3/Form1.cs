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
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int iData03 = int.Parse(textBox3.Text);

                int iData04 = iData01 * 10 * iData02 * 10 * iData03 * 10;

                label4.Text = "직육면체 가로:" + iData01 * 10 + "mm 세로:" + iData02 * 10 + "mm높이:" + iData03 * 10 + "mm의\n부피는" + iData04 + "입니다.";
                    
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int iData03 = int.Parse(textBox3.Text);

                int iData04 = iData01 * iData02 * iData03;

                label4.Text = "직육면체 가로:" + iData01 +
                    "cm 세로:" + iData02 + "cm높이:" + iData03  + "cm의\n부피는" + iData04 + "입니다.";

            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int iData03 = int.Parse(textBox3.Text);

                int iData04 = iData01 / 10 * iData02 / 10 * iData03 / 10;

                label4.Text = "직육면체 가로:" + iData01 / 10 +
                    "mm 세로:" + iData02 / 10 + "mm높이:" + iData03 / 10 + "mm의\n부피는" + iData04 + "입니다.";

            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "결과가 표시되는 곳입니다.";
        }
    }
}
