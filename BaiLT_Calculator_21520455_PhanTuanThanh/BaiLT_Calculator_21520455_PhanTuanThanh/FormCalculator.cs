using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLT_Calculator_21520455_PhanTuanThanh
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
            disableAllButton();
        }

        private void disableAllButton()
        {
            this.panelScreen.Enabled = false;
            this.tableLayoutPanelNumber.Enabled = false;
            this.buttonOff.Enabled = false;
            this.buttonDel.Enabled = false; 
            this.buttonClear.Enabled = false;
        }

        private void enableAllButton()
        {
            this.panelScreen.Enabled = true;
            this.tableLayoutPanelNumber.Enabled = true;
            this.buttonOff.Enabled = true;
            this.buttonDel.Enabled = true;
            this.buttonClear.Enabled = true;
        }


        bool isResult;
        private void buttonOn_Click(object sender, EventArgs e)
        {
            enableAllButton();
            isResult = false;
            this.textBoxScreen.Text = "0";
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            disableAllButton();
            this.textBoxScreen.Text = String.Empty;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            isResult = false;
            this.textBoxScreen.Text = "0";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string s = this.textBoxScreen.Text;
            if (s.Length > 1)
                s = s.Substring(0, s.Length - 1);
            else
            {
                isResult = false;
                s = "0";
            }
            this.textBoxScreen.Text = s;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!isResult)
                this.textBoxScreen.Text = String.Empty;
            isResult = true;
            this.textBoxScreen.Text += "9";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text += "+";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text += "-";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text += "x";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text += "/";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            this.textBoxScreen.Text += ".";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string expression = this.textBoxScreen.Text;

            char[] symbol = { '+', '-', 'x', '/' };
            string[] numbers = expression.Split('+', '-', 'x', '/');

            if (numbers.Length <= 1)
            {
                MessageBox.Show("Vui lòng nhập đủ 2 số!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char c = ' ';
            foreach (char x in expression)
            {
                if (x == '.') continue;
                if (x < '0' || x > '9')
                {
                    c = x;
                    break;
                }
            }

            isResult = true;
            double sum = 0, num1 = double.Parse(numbers[0]), num2 = double.Parse(numbers[1]); 
            if (c == '+')
            {
                sum = num1 + num2;
                this.textBoxScreen.Text = sum.ToString();
                return;
            }
            if (c == '-')
            {
                sum = num1 - num2;
                this.textBoxScreen.Text = sum.ToString();
                return;
            }
            if (c == 'x')
            {
                sum = num1 * num2;
                this.textBoxScreen.Text = sum.ToString();
                return;
            }
            if (c == '/')
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Không thể chia cho 0.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sum = num1 / num2;
                this.textBoxScreen.Text = sum.ToString();
                return;
            }
        }


    }
}
