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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBox1.Text;
                if(str.IndexOf("-") == -1 && str.Length == 13)
                {
                    int[] array1 = new int[13];

                    for (int i = 0; i < 13; i++)
                    {
                        array1[i] = int.Parse(str.Substring(i, 1));
                    }
                    int y = 0;

                    for(int i = 0; i < 8; i++)
                    {
                        y += array1[i] * (i + 2);
                    }
                    for(int i = 8; i < 12; i++)
                    {
                        y += array1[i] * (i - 6);
                    }

                    int z = (11 - (y % 11)) % 10;

                    if(z == array1[12])
                    {
                        label2.Text = "올바른 주민등록번호";
                    }
                    else
                    {
                        label2.Text = "잘못된 주민등록번호";
                    }
                }
            }
            catch(Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
