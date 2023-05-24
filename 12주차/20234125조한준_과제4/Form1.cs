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
        public Form1()
        {
            InitializeComponent();
            label6.Image = Properties.Resources.car_0;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            listBox2.Items.Clear();

            listBox2.Items.Add("선택차종:"+"\n");

          if(radioButton1.Checked == true)
              {
                  label6.Image = Properties.Resources.car_1;
                  listBox2.Items.Add("          승용차");
                   cnt += 100;
              }
          else if (radioButton2.Checked == true)
          {
              label6.Image = Properties.Resources.car_2;
              listBox2.Items.Add("          트럭");
              cnt += 80;
          }
          else if (radioButton3.Checked == true)
          {
              label6.Image = Properties.Resources.car_3;
              listBox2.Items.Add("          봉고차");
              cnt += 50;         
         }

          listBox2.Items.Add("---------------------"+"\n");
          listBox2.Items.Add("선택옵션:"+"\n");

          if (checkBox1.Checked == true)
          {
              listBox2.Items.Add("          썬루프");
              cnt += 1;
          }
          if (checkBox2.Checked == true)
          {
              listBox2.Items.Add("          GPS");
              cnt += 3;
          }
          if (checkBox3.Checked == true)
          {
              listBox2.Items.Add("          에어백");
              cnt += 10;
          }
          if (checkBox4.Checked == true)
          {
              listBox2.Items.Add("          자동온도조절장치");
              cnt += 2;
          }
          if (checkBox5.Checked == true)
          {
              listBox2.Items.Add("          도난방지시스템");
              cnt += 2;
          }

                      listBox2.Items.Add("---------------------" + "\n");
          listBox2.Items.Add("결재방법:" + "\n");

                       if(comboBox1.SelectedIndex == 0)
            {
                                  listBox2.Items.Add("          일시불");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                  listBox2.Items.Add("무통장입금");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                  listBox2.Items.Add("신용카드");
            }

          listBox2.Items.Add("---------------------" + "\n");
          listBox2.Items.Add("견적금액:" + "\n");

          listBox2.Items.Add("        "+cnt + "만원");

          label1.Text = "견적가 : " + cnt + "만원";

        }
    }
}
