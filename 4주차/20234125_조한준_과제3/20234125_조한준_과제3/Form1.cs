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

        private void button2_Click(object sender, EventArgs e)
        {
          
            textBox3.Text = "";
            label4.Text = "결과가 나오는 곳입니다!";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idata01 = int.Parse(textBox1.Text);
                int idata02 = int.Parse(textBox2.Text);
                string sdata01 = textBox3.Text;

                bool result;

                if (sdata01 == "!=")
                {
                    result = idata01 != idata02;
                    label4.Text = idata01 + sdata01 + idata02
                        + "의 결과는" + result;
                }
                else if (sdata01 == "<")
                {
                    result = idata01 < idata02;
                    label4.Text = idata01 + sdata01 + idata02
                        + "의 결과는" + result;
                }
                else if (sdata01 == ">")
                {
                    result = idata01 > idata02;
                    label4.Text = idata01 + sdata01 + idata02
                        + "의 결과는" + result;
                }
                else if (sdata01 == "<=")
                {
                     result = idata01 <= idata02;
                    label4.Text = idata01 + sdata01 + idata02
                        + "의 결과는" + result;
                }
                else if (sdata01 == "=>")
                {
                    result = idata01 != idata02;
                    label4.Text = idata01 + sdata01 + idata02
                        + "의 결과는" + result;
                }
                else if (sdata01 == "==")
                {
                    result = idata01 != idata02;
                    label4.Text = idata01 + sdata01 + idata02
                        + "의 결과는" + result;
                }
                else if (sdata01 == "")
                {
                    label4.Text = "Operator에 관계연산자 하나를 입력하세요!";
                }
                else
                {
                    label4.Text = "알 수 없는 관계연산자입니다.";
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
