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
                int[] iarray = new int[10];
                System.Random rannum = new System.Random();
                double avg = 0;
                for (int i = 0; i < 10; i++)
                {
                    iarray[i] = rannum.Next(1, 100);
                    avg += iarray[i];
                }
                avg = avg / 10;

                string str = "";


                for (int i = 0; i < 10; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        str += "iarray[" + i + "]=" + iarray[i] + " \n";
                    }
                    else
                    {
                        str += "iarray[" + i + "]=" + iarray[i] + " ";
                    }
                    label1.Text = str;

                    label2.Text = "10개 원소 배열값의 평균은 " + avg;
                }
            }

            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
