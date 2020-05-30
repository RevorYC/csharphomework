using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
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
                if (comboBox1.Text == "")
                {
                    result.Text = "请选择运算符";
                }
                else if (texta.Text == "" || textb.Text == "")
                {
                    result.Text = "请输入运算数字";
                }
                else
                {
                    double a = double.Parse(texta.Text);
                    double b = double.Parse(textb.Text);
                    switch (comboBox1.Text)
                    {
                        case "+":
                            result.Text = $"{a + b}";
                            break;
                        case "-":
                            result.Text = $"{a - b}";
                            break;
                        case "*":
                            result.Text = $"{ a * b}";
                            break;
                        case "/":
                            if (b == 0)
                                result.Text = "除数不可为零！";
                            else
                                result.Text = $"{ a / b}";
                            break;
                    }
                }
            }
            catch {
                result.Text = "输入有误，请输入正确数据";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
