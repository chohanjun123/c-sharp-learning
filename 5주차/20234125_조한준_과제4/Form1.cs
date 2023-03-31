using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234125_조한준_과제4
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
                string sdata01 = textBox1.Text;
                switch (sdata01)
                {
                    case "int":
                        label1.Text=sdata01+"의 허용값은"+int.MinValue+"~"+int.MaxValue;
                        break;

                    case "uint":
                        label1.Text = sdata01 + "의 허용값은" + uint.MinValue + "~" + uint.MaxValue;
                        break;

                    case "float":
                        label1.Text = sdata01 + "의 허용값은" + float.MinValue + "~" + float.MaxValue;
                        break;

                    case "double":
                        label1.Text = sdata01 + "의 허용값은" + double.MinValue + "~" + double.MaxValue;
                        break;

                    case "long":
                        label1.Text = sdata01 + "의 허용값은" + long.MinValue + "~" + long.MaxValue;
                        break;

                    case "ulong":
                        label1.Text = sdata01 + "의 허용값은" + ulong.MinValue + "~" + ulong.MaxValue;
                        break;

                    case "byte":
                        label1.Text = sdata01 + "의 허용값은" + byte.MinValue + "~" + byte.MaxValue;
                        break;

                    case "sbyte":
                        label1.Text = sdata01 + "의 허용값은" + sbyte.MinValue + "~" + sbyte.MaxValue;
                        break;

                    case "short":
                        label1.Text = sdata01 + "의 허용값은" + short.MinValue + "~" + short.MaxValue;
                        break;

                    case "ushort":
                        label1.Text = sdata01 + "의 허용값은" + ushort.MinValue + "~" + ushort.MaxValue;
                        break;

                    case "":
                        label1.Text = "10가지 data중 하나를 입력하세요!";
                        break;

                    default:
                        label1.Text="알 수 없는 데이터입니다";
                            break;
                }
            }
            catch (Exception ex)
            {
                
                label1.Text = ex.Message;
            }

        }
    }
}
