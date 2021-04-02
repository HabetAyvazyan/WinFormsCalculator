using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        double number1;
        double number2;
        string action;
        public Form1()
        {
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
            textBox1.Text += ((Button) sender).Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            number1 = Convert.ToDouble(textBox1.Text);
            action = btn.Text;
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
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
