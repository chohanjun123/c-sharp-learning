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
        CheckBox[] chkmgr;
        public Form1()
        {
            InitializeComponent();
            chkmgr = new CheckBox[20];
            chkmgr[0] = checkBox1;
            chkmgr[1] = checkBox2;
            chkmgr[2] = checkBox3;
            chkmgr[3] = checkBox4;
            chkmgr[4] = checkBox5;
            chkmgr[5] = checkBox6;
            chkmgr[6] = checkBox7;
            chkmgr[7] = checkBox8;
            chkmgr[8] = checkBox9;
            chkmgr[9] = checkBox10;
            chkmgr[10] = checkBox11;
            chkmgr[11] = checkBox12;
            chkmgr[12] = checkBox13;
            chkmgr[13] = checkBox14;
            chkmgr[14] = checkBox15;
            chkmgr[15] = checkBox16;
            chkmgr[16] = checkBox17;
            chkmgr[17] = checkBox18;
            chkmgr[18] = checkBox19;
            chkmgr[19] = checkBox20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random rannum = new System.Random();

            for(int i = 0; i < 20; i++)
            {
                chkmgr[i].Text = rannum.Next(1, 100).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double compt = 0;
            double sum = 0;
            double average = 0;

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.Items.Add("각 체크박스의 숫자들\n");
            listBox1.Items.Add("-----------------------\n");

            listBox2.Items.Add("선택된 체크박스의 숫자들\n");
            listBox2.Items.Add("-----------------------\n");

            for(int i = 0; i < 20; i++)
            {
                listBox1.Items.Add("checkbox" + (i + 1) + " = " + chkmgr[i].Text);
            }

            for(int i = 0; i < 20; i++)
            {
                if(chkmgr[i].Checked == true)
                {
                    listBox2.Items.Add("checkbox" + (i + 1) + " = " + chkmgr[i].Text);
                    compt++;
                    sum += double.Parse(chkmgr[i].Text);
                }
            }

            listBox2.Items.Add("-----------------------\n");
            listBox2.Items.Add("선택된 항목의 합계\n");
            listBox2.Items.Add("-----------------------\n");
            listBox2.Items.Add("합계 -> " + sum + "\n");

                            listBox2.Items.Add("-----------------------\n");

            listBox2.Items.Add("선택된 항목의 평균\n");
            listBox2.Items.Add("-----------------------\n");
            listBox2.Items.Add("평균 -> " + sum / compt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            

            for(int i = 0; i < 20; i++)
            {
                chkmgr[i].Text = "checkbox" + (i + 1);
            }
        }
    }
}
