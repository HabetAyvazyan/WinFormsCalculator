using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        List<string> numStrList;
        string numStr;
        double number1;
        double number2;
        string action;
        List<char> actionChars = new List<char>(){'+','-', '÷', '×'};
        bool operation;
        public Form1()
        {
            //if (operation == true && textBox1.Text != null)
            //{
            //    number2 = Convert.ToDouble(textBox1.Text);
            //}
            //if (action == "+")
            //{
            //    textBox1.Text = (number1 + number2).ToString();
            //}
            //else if (action == "-")
            //{
            //    textBox1.Text = (number1 - number2).ToString();
            //}
            //else if (action == "×")
            //{
            //    textBox1.Text = (number1 * number2).ToString();
            //}
            //else if (action == "÷")
            //{
            //    textBox1.Text = (number1 / number2).ToString();
            //}
            InitializeComponent();
        }
        

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void number_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += ((Button)sender).Text;
            if (textBox1.Text != "" && operation == true)
            {

                number2 = Convert.ToDouble(textBox1.Text);
            }
            //if (//actionChars.Count(c => textBox1.Text.Contains(c)) == 2)
            //    textBox1.Text.IndexOfAny(new char[] { '+', '-', '÷', '×' }) != -1)
            //{
            //    number2 = Convert.ToDouble(textBox1.Text.Split(action)[1]);
            //    //if(textBox1.Text.IndexOfAny(new char[] { '+', '-', '÷', '×' }) != -1)
                
            //}
        }
        
        private void operator_Click(object sender, EventArgs e)
        {
            operation = true;
            Button btn = sender as Button;
            action = btn.Text;
            number1 = Convert.ToDouble(textBox1.Text);
            //textBox1.Text += btn.Text;
            if (action == "÷")
            {
                textBox1.Text = (number1 / number2).ToString();
            }
            else if (action == "+")
            {
                textBox1.Text = (number1 + number2).ToString();
            }
            else if (action == "-")
            {
                textBox1.Text = (number1 - number2).ToString();
            }
            else if (action == "×")
            {
                textBox1.Text = (number1 * number2).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = number1.ToString();
            }
            else
            {
                number2 = double.Parse(textBox1.Text);
                if (action == "+")
                {
                    textBox1.Text = (number1 + number2).ToString();
                }
                else if (action == "-")
                {
                    textBox1.Text = (number1 - number2).ToString();
                }
                else if (action == "×")
                {
                    textBox1.Text = (number1 * number2).ToString();
                }
                else if (action == "÷")
                {
                    textBox1.Text = (number1 / number2).ToString();
                }

            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            double number = Double.Parse(textBox1.Text);
            textBox1.Text = (number * number).ToString();
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0,1);
                }
                else
                {
                    textBox1.Text = '-' + textBox1.Text;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf('.') == -1)
            {
                textBox1.Text += ".";
            }
        }
    }
}
