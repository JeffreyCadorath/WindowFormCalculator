using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {

        double FirstNumber;
        string Operator;
        public static string ToBinary(int n)
        {
            string result = " ";
            while (n > 0)
            {
                int remainder = n % 2;
                result = remainder + result;
                n = n / 2;
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && textBox1.Text == "")
            {
                textBox1.Text = "You must choose your number first, Clear me";
                checkBox1.Checked = false;
            }
            else if (checkBox1.Checked)
            {
                textBox1.Text = ToBinary(int.Parse(textBox1.Text));
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = ("-" + textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Enter && e.KeyChar != (Char)Keys.Back && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Plus
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = null;
            }
            else
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = null;
                Operator = "+";
                checkBox1.Checked = false;
            }

        }
        //Multiply
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = null;
            }
            else
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = null;
                Operator = "X";
                checkBox1.Checked = false;
            }
        }
        //Minus
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = null;
            }
            else
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = null;
                Operator = "-";
                checkBox1.Checked = false;
            }
        }
        //Divide
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = null;
            }
            else
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = null;
                Operator = "/";
                checkBox1.Checked = false;
            }
        }
        //Power Of
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = null;
            }
            else
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = null;
                Operator = "PO";
                checkBox1.Checked = false;
            }
        }
        //Squared
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = null;
            }
            else
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = FirstNumber.ToString();
                Operator = "X²";
                checkBox1.Checked = false;
            }
        }
        //Square Root
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = null;
            }
            else
            {
                FirstNumber = double.Parse(textBox1.Text);
                textBox1.Text = FirstNumber.ToString();
                Operator = "√";

            }
        }

        //Clear
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            checkBox1.Checked = false;
        }
        //Equal
        private void button6_Click(object sender, EventArgs e)
        {
            int SecondNumber;
            double Result;
            if (checkBox1.Checked)
            {
                SecondNumber = int.Parse(textBox1.Text);
                textBox1.Text = ToBinary(SecondNumber);
                textBox1.Text = SecondNumber.ToString();
                if (textBox1.Text == "")
                {
                    textBox1.Text = null;
                }
                else if (Operator == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Text = ToBinary((int)Result).ToString();
                    FirstNumber = Result;
                }
                else if (Operator == "X")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = ToBinary((int)Result).ToString();
                    FirstNumber = Result;

                }
                else if (Operator == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = ToBinary((int)Result).ToString();
                    FirstNumber = Result;

                }
                else if (Operator == "/")
                {
                    if (SecondNumber == 0)
                    {
                        textBox1.Text = "Cannot divide by 0";
                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox1.Text = ToBinary((int)Result).ToString();
                        FirstNumber = Result;
                    }
                }
                else if (Operator == "X²")
                {
                    SecondNumber = (int)FirstNumber;
                    textBox1.Text = FirstNumber.ToString();
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = ToBinary((int)Result).ToString();
                    FirstNumber = Result;

                }
                else if (Operator == "PO")
                {
                    Result = Math.Pow(FirstNumber, SecondNumber);
                    textBox1.Text = Result.ToString();
                    FirstNumber = Result;

                }
                else if (Operator == "√")
                {
                    SecondNumber = (int)FirstNumber;
                    textBox1.Text = FirstNumber.ToString();
                    Result = Math.Sqrt(FirstNumber);
                    textBox1.Text = Result.ToString();
                    FirstNumber = Result;

                }
            }
            else
            {
                SecondNumber = (int)double.Parse(textBox1.Text);
                if (textBox1.Text == "")
                {
                    textBox1.Text = null;
                }
                else if (Operator == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Text = Result.ToString();
                    FirstNumber = Result;
                }
                else if (Operator == "X")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Result.ToString();
                    FirstNumber = Result;

                }
                else if (Operator == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = Result.ToString();
                    FirstNumber = Result;

                }
                else if (Operator == "/")
                {
                    if (SecondNumber == 0)
                    {
                        textBox1.Text = "Cannot divide by 0";
                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox1.Text = Result.ToString();
                        FirstNumber = Result;
                    }
                }
                else if (Operator == "X²")
                {
                    SecondNumber = (int)FirstNumber;
                    textBox1.Text = FirstNumber.ToString();
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Result.ToString();
                    FirstNumber = Result;

                }
                else if (Operator == "PO")
                {
                    Result = Math.Pow(FirstNumber, SecondNumber);
                    textBox1.Text = Result.ToString();
                    FirstNumber = Result;

                }
                else if (Operator == "√")
                {
                    SecondNumber = (int)FirstNumber;
                    textBox1.Text = FirstNumber.ToString();
                    Result = Math.Sqrt(FirstNumber);
                    textBox1.Text = Result.ToString();
                    FirstNumber = Result;

                }
            }

        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-1"))
            {
                textBox1.Text = textBox1.Text + "-1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-2"))
            {
                textBox1.Text = textBox1.Text + "-2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-3"))
            {
                textBox1.Text = textBox1.Text + "-3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-4"))
            {
                textBox1.Text = textBox1.Text + "-4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-5"))
            {
                textBox1.Text = textBox1.Text + "-5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-6"))
            {
                textBox1.Text = textBox1.Text + "-6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-7"))
            {
                textBox1.Text = textBox1.Text + "-7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-8"))
            {
                textBox1.Text = textBox1.Text + "-8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else if (checkBox2.Checked && !textBox1.Text.Any(x => x.ToString() != "-9"))
            {
                textBox1.Text = textBox1.Text + "-9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
    }
}
