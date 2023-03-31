using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125_조한준_과제3
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

                switch (idata01)
                {
                    case 1:
                        label2.Text = "입력값" + idata01 + "--> January";
                        break;

                    case 2:
                        label2.Text = "입력값" + idata01 + "--> February";
                        break;

                    case 3:
                        label2.Text = "입력값" + idata01 + "--> March";
                        break;

                    case 4:
                        label2.Text = "입력값" + idata01 + "--> April";
                        break;

                    case 5:
                        label2.Text = "입력값" + idata01 + "--> May";
                        break;

                    case 6:
                        label2.Text = "입력값" + idata01 + "--> June";
                        break;

                    case 7:
                        label2.Text = "입력값" + idata01 + "--> July";
                        break;

                    case 8:
                        label2.Text = "입력값" + idata01 + "--> August";
                        break;

                    case 9:
                        label2.Text = "입력값" + idata01 + "--> September";
                        break;

                    case 10:
                        label2.Text = "입력값" + idata01 + "--> October";
                        break;

                    case 11:
                        label2.Text = "입력값" + idata01 + "--> November";
                        break;

                    case 12:
                        label2.Text = "입력값" + idata01 + "--> December";
                        break;

                    default:
                        label2.Text = "해당하는 month 가 없으니 1~12사이의 수를 입력하세요.";
                        break;
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
