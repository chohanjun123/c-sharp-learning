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
            try
            {
                string[] unacceptable = new string[4];
                unacceptable[0] = "바보";
                unacceptable[1] = "메롱";
                unacceptable[2] = "님아";
                unacceptable[3] = "8억";

                string str = textBox1.Text;

                foreach(string str2 in unacceptable)
                {
                    int fp = str.IndexOf(str2);

                    while(fp >= 0)
                    {
                        string ap = str.Substring(0, fp);
                        string bp = str.Substring(fp + str2.Length);
                        str = ap + "(금지어)" + bp;
                        fp = str.IndexOf(str2);
                    }
                }
                textBox1.Text = str;

            }
            catch
            {

            }
        }
    }
}
