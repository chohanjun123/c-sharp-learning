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
        bool ismodified = false;
        bool hasfilename = false;
        string sfilename = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ismodified = true;
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            if(ismodified == true)
            {
                DialogResult answer = MessageBox.Show(
                    "변경된 내용을 저장하시겠습니다까?", "저장",
                    MessageBoxButtons.YesNo);
                if(answer == DialogResult.Yes)
                {
                    if(hasfilename == true)
                    {
                        System.IO.StreamWriter fs =
                            System.IO.File.CreateText(sfilename);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        ismodified = false;
                    }
                    else
                    {
                        if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            sfilename = saveFileDialog1.FileName;
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            hasfilename = true;
                            ismodified = false;
                        }
                    }
                }
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sfilename = openFileDialog1.FileName;
                    System.IO.StreamReader fs =
                        System.IO.File.OpenText(sfilename);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    hasfilename = true;
                    ismodified = false;
                }
            }
            }
            catch
            {
                MessageBox.Show("열기를 하는 도중 이상이 발생했습니다.",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 새로만들기nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(ismodified == true)
                {
                    DialogResult answer = MessageBox.Show(
                        "변경딘 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);
                    if(answer == DialogResult.Yes)
                    {
                        if(hasfilename == true)
                        {
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;
                        }
                        else
                        {
                            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sfilename = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs =
                                    System.IO.File.CreateText(sfilename);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasfilename = true;
                                ismodified = false;
                            }
                        }
                    }
                }
                textBox1.Text = "";
                ismodified = false;
                hasfilename = false;
                sfilename = "";
            }
            catch
            {
                MessageBox.Show("새 파일을 준비하는 도중 이상이 발생했습니다.",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(hasfilename == true)
                {
                    System.IO.StreamWriter fs =
                        System.IO.File.CreateText(sfilename);
                    fs.WriteLine(textBox1.Text);
                    fs.Close();
                    ismodified = false;
                }
                else
                {
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        sfilename = saveFileDialog1.FileName;
                        System.IO.StreamWriter fs =
                            System.IO.File.CreateText(sfilename);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        hasfilename = true;
                        ismodified = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("저장을 하는 도중 이상이 발생했습니다.",
    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ismodified == true)
                {
                    DialogResult answer = MessageBox.Show(
                        "변경된 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);
                    if(answer == DialogResult.Yes)
                    {
                        if(hasfilename == true)
                        {
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;
                        }
                        else
                        {
                            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sfilename = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs =
                                    System.IO.File.CreateText(sfilename);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasfilename = true;
                                ismodified = false;
                            }
                        }
                    }
                }
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("끝내는 도중 이상이 발생했습니다.",
    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {             
                textBox1.Cut();
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 붙여넣기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 삭제DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;

        }

        private void 색깔CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ismodified == true)
                {
                    DialogResult answer = MessageBox.Show(
                        "변경된 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (hasfilename == true)
                        {
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sfilename);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            ismodified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sfilename = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs =
                                    System.IO.File.CreateText(sfilename);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasfilename = true;
                                ismodified = false;
                            }
                        }
                    }
                }
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("끝내는 도중 이상이 발생했습니다.",
    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
