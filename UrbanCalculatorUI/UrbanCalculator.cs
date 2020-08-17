using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UrbanCalculatorUI
{
    public partial class UrbanCalculator : Form
    {
        string mathOperator = "";
        double currentAns, operated;
        bool reset = false;


        public UrbanCalculator()
        {
            InitializeComponent();
        }

        private void numbers(object sender, EventArgs e)
        {
            Button addDigit = (Button)sender;
            if(visDisplay.Text.Length < 16)
            {
                if (visDisplay.Text == "0")
                    visDisplay.Text = "";
                if (addDigit.Text == "." && reset == true)
                {
                    if (visDisplay.Text == "")
                        visDisplay.Text += "0";
                    if (!visDisplay.Text.Contains("."))
                        visDisplay.Text += addDigit.Text;
                }
                else if (mathOperator != "" && reset == true)
                {
                    visDisplay.Text = "";
                    visDisplay.Text += addDigit.Text;
                    reset = false;
                }
                else
                    visDisplay.Text += addDigit.Text;
                operated = double.Parse(visDisplay.Text);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (visDisplay.Text.Length > 1)
                visDisplay.Text = visDisplay.Text.Remove(visDisplay.Text.Length - 1);
            else
                visDisplay.Text = "0";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            visDisplay.Text = "0";
            operated = 0;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            visDisplay.Text = "0";
            mathOperator = "";
            currentAns = 0;
            operated = 0;
        }

        //private void UrbanCalculator_Load(object sender, EventArgs e)
        //{

        //}


        private void operators(object sender, EventArgs e)
        {
            Button currentOperator = (Button)sender;
            if (mathOperator == "+")
                visDisplay.Text = (currentAns + operated).ToString();
            else if (mathOperator == "-")
                visDisplay.Text = (currentAns - operated).ToString();
            else if (mathOperator == "x")
                visDisplay.Text = (currentAns * operated).ToString();
            else if (mathOperator == "÷")
                visDisplay.Text = (currentAns / operated).ToString();
            currentAns = double.Parse(visDisplay.Text);
            mathOperator = currentOperator.Text;
            operated = mathOperator == "+" || mathOperator == "-" ? 0 : 1;
            reset = true; 

        }

        private void NegationBtn_Click(object sender, EventArgs e)
        {
            if (visDisplay.Text.Contains("-"))
                visDisplay.Text = visDisplay.Text.Remove(0, 1);
            else
                visDisplay.Text = "-" + visDisplay.Text;
            operated = double.Parse(visDisplay.Text);
        }

        private void equaltoBtn_Click(object sender, EventArgs e)
        {
            if (mathOperator == "+")
                visDisplay.Text = (currentAns + operated).ToString();
            else if(mathOperator == "-")
                visDisplay.Text = (currentAns - operated).ToString();
            else if(mathOperator == "x")
                visDisplay.Text = (currentAns * operated).ToString();
            else if(mathOperator == "÷")
                visDisplay.Text = (currentAns / operated).ToString();
            reset = true;
            currentAns = double.Parse(visDisplay.Text);
            mathOperator = "";
            operated = 0;
        }

    }
}
