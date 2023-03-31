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
                char cdata01 = char.Parse(textBox1.Text);
                if (cdata01 >= 'a' && cdata01 <= 'z'|| cdata01>='A' && cdata01<='Z')
                {


                    switch (cdata01)
                    {
                        case 'a':

                        case 'e':

                        case 'o':

                        case 'u':

                        case 'i':

                        case 'A':

                        case 'E':

                        case 'O':

                        case 'U':

                        case 'I':
                            label2.Text = cdata01 + "는 모음";
                            break;

                        default:
                            label2.Text = cdata01 + "는 자음";
                            break;
                    }
                }
                else
                {
                    label2.Text = cdata01 + "를 입력했습니다 영문 알파벳을 입력해주세요.";
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
