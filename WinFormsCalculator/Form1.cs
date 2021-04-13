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
        double number1;
        double number2;
        string action;
        List<char> actionChars = new List<char>() {'+', '−', '÷', '×'};
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
            action = btn.Text;
            var s = textBox1.Text.Split('+', '−', '÷', '×');
            if (actionChars.Any(a=> textBox1.Text.Contains(a)) && s.Length == 2)
            {
                var spl = textBox1.Text.Split('+', '−', '÷', '×');
                try
                {
                    number1 = Double.Parse(spl[0]);
                    number2 = Double.Parse(spl[1]);
                }
                catch (Exception exception)
                {
                     
                }
                if (textBox1.Text.Contains("÷"))
                {
                    textBox1.Text = (number1 / number2).ToString();
                }
                else if (textBox1.Text.Contains("+"))
                {
                    textBox1.Text = (number1 + number2).ToString();
                }
                else if (textBox1.Text.Contains("−"))
                {
                    textBox1.Text = (number1 - number2).ToString();
                }
                else if (textBox1.Text.Contains("×"))
                {
                    textBox1.Text = (number1 * number2).ToString();
                }
                textBox1.Text += action;
            }
            else if (!actionChars.Any(a => textBox1.Text.Contains(a)))
            {
                textBox1.Text += action;
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
                var sp = textBox1.Text.Split('+', '−', '÷', '×');
                number1 = double.Parse(sp[0]);
                number2 = double.Parse(sp[1]);
                if (action == "+")
                {
                    textBox1.Text = (number1 + number2).ToString();
                }
                else if (action == "−")
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
                    textBox1.Text = textBox1.Text.Remove(0, 1);
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
