using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125_조한준_과제2
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
                    label2.Text ="";
                    label3.Text = "";


                    label2.Text = "수행된 i 값: ";
                    for (int i = 1; i <= idata01; i++)
                    {
                        label3.Text += i + ", ";
                        if(i % 7 == 0)
                        {
                            label3.Text += "\n";
                        }
                    }
                    label3.Text = label3.Text.TrimEnd(',',' ');

                    if (idata01 >= 21)
                    {
                        label3.Text = "1과 20사이의 수를 입력하세요!";
                        label2.Text = "";
                    }
                    else if (idata01 <= 0)
                    {
                          label3.Text = "1과 20사이의 수를 입력하세요!";
                          label2.Text = "";
                    }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
                label3.Text = "";
            }
        }
    }
}
