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
                int[] iarray = new int[100];
                for (int i = 0; i < 100; i++)
                {
                    iarray[i] = i + 1;
                }
                string str = "";
                int cnt = 0;
                foreach (int i in iarray)
                {
                    cnt++;
                    if (cnt % 10 == 0)
                    {
                        str += i + " \n";
                    }
                    else
                    {
                        str += i + " ";
                    }
                }
                label1.Text = str;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
