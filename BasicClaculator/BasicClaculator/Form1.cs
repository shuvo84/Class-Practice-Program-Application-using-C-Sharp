using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicClaculator
{
    public partial class Form1 : Form
    {
        string operation;
        double firstNumber;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
                resultTextBox.Clear();
            Button button = (Button)sender;
            resultTextBox.Text = resultTextBox.Text + button.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(resultTextBox.Text);
            resultTextBox.Text = "0";
            operation = "+";
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(resultTextBox.Text);
            resultTextBox.Text = "0";
            operation = "-";
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(resultTextBox.Text);
            resultTextBox.Text = "0";
            operation = "*";
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(resultTextBox.Text);
            resultTextBox.Text = "0";
            operation = "/";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                result = firstNumber + Double.Parse(resultTextBox.Text);
                resultTextBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "-")
            {
                result = firstNumber - Double.Parse(resultTextBox.Text);
                resultTextBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "*")
            {
                result = firstNumber * Double.Parse(resultTextBox.Text);
                resultTextBox.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "/")
            {
                if (resultTextBox.Text == "0")
                    resultTextBox.Text = "Division Error";
                else {
                    result = firstNumber / Double.Parse(resultTextBox.Text);
                    resultTextBox.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
