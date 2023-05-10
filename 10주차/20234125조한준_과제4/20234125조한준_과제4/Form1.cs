using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125조한준_과제4
{
    public partial class Form1 : Form


    {

        int win = 0;
        int draw = 0;
        int lose = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "가위";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "바위";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "보";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string user = textBox1.Text;
                if (user == "가위" || user == "바위" || user == "보")
                {
                    System.Random rannum = new System.Random();
                    int sysnum = rannum.Next(1, 4);
                    string syschoice = "";
                    if (sysnum == 1)
                    {
                        syschoice = "가위";
                    }
                    else if (sysnum == 2)
                    {
                        syschoice = "바위";
                    }
                    else
                    {
                        syschoice = "보";
                    }
                    if (user == "가위" && syschoice == "가위")
                    {
                        draw++;
                        label1.Text = "user는 가위";
                        label2.Text = "System은 가위";
                        label3.Text = "결과는 무승부";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }
                    else if (user == "가위" && syschoice == "바위")
                    {
                        lose++;
                        label1.Text = "user는 가위";
                        label2.Text = "System은 바위";
                        label3.Text = "결과는 패";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }
                    else if (user == "가위" && syschoice == "보")
                    {
                        win++;
                        label1.Text = "user는 가위";
                        label2.Text = "System은 보";
                        label3.Text = "결과는 승";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }
                    else if (user == "바위" && syschoice == "가위")
                    {
                        win++;
                        label1.Text = "user는 바위";
                        label2.Text = "System은 가위";
                        label3.Text = "결과는 승";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }
                    else if (user == "바위" && syschoice == "바위")
                    {
                        draw++;
                        label1.Text = "user는 바위";
                        label2.Text = "System은 바위";
                        label3.Text = "결과는 무승부";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }
                    else if (user == "바위" && syschoice == "보")
                    {
                        lose++;
                        label1.Text = "user는 바위";
                        label2.Text = "System은 보";
                        label3.Text = "결과는 패";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }
                    else if (user == "보" && syschoice == "가위")
                    {
                        lose++;
                        label1.Text = "user는 보";
                        label2.Text = "System은 가위";
                        label3.Text = "결과는 패";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }
                    else if (user == "보" && syschoice == "바위")
                    {
                        win++;
                        label1.Text = "user는 보";
                        label2.Text = "System은 바위";
                        label3.Text = "결과는 승";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }
                    else if (user == "보" && syschoice == "보")
                    {
                        draw++;
                        label1.Text = "user는 보";
                        label2.Text = "System은 보";
                        label3.Text = "결과는 무승부";
                        label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                    }

                    textBox1.Text = "";

                }
                else
                {
                    lose++;
                    label1.Text = "입력값이 '가위,바위,보'\n중 하나가 아니어서 패 처리합니다.";
                    label4.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패 ";
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
