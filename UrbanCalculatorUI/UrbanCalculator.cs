using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UrbanCalculator;

namespace UrbanCalculatorUI
{
    public partial class UrbanCalculator : Form
    {
        private readonly ICalculationFactory Factory;
        string mathOperator = "";
        string currentAns, operated;
        bool reset = false;

        public UrbanCalculator(ICalculationFactory factory)
        {
           
            InitializeComponent();
            Factory = factory;
        }

        private void numbers(object sender, EventArgs e)
        {
            Button addDigit = (Button)sender;
            try
            {
                if (visDisplay.Text.Length >= 15)
                {
                    throw new IndexOutOfRangeException();
                }

                if (visDisplay.Text == "0")
                    visDisplay.Text = "";
                if (reset == true)
                {
                    visDisplay.Text = "";
                    reset = false;
                }
                if (addDigit.Text == "." && reset == true)
                {
                    if (visDisplay.Text == "")
                        visDisplay.Text += "0";
                    if (!visDisplay.Text.Contains("."))
                        visDisplay.Text += addDigit.Text;
                    reset = false;
                }
                else if (mathOperator != "" && reset == true)
                {
                    visDisplay.Text = "";
                    visDisplay.Text += addDigit.Text;
                    reset = false;
                }
                else
                    visDisplay.Text += addDigit.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                resetCalculator();
            }           
            operated = visDisplay.Text;
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
            operated = "0";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resetCalculator();
        }

        private void operators(object sender, EventArgs e)
        {
            Button currentOperator = (Button)sender;
            try
            {
                if (mathOperator == "+")
                    visDisplay.Text = Factory.AdditionOperation(currentAns, operated);
                else if (mathOperator == "-")
                    visDisplay.Text = Factory.SubtractionOperation(currentAns, operated);
                else if (mathOperator == "x")
                    visDisplay.Text = Factory.MultiplyOperation(currentAns, operated);
                else if (mathOperator == "÷")
                    visDisplay.Text = Factory.DivisionOperation(currentAns, operated);
                currentAns = visDisplay.Text;
                mathOperator = currentOperator.Text;
                reset = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                resetCalculator();
            }
        }
        void resetCalculator()
        {
            visDisplay.Text = "0";
            mathOperator = "";
            currentAns = "0";
            operated = "0";
        }
        private void NegationBtn_Click(object sender, EventArgs e)
        {
            if (visDisplay.Text.Contains("-"))
                visDisplay.Text = visDisplay.Text.Remove(0, 1);
            else
                visDisplay.Text = "-" + visDisplay.Text;
            operated = visDisplay.Text;
        }


        private void equaltoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mathOperator == "+")
                    visDisplay.Text = Factory.AdditionOperation(currentAns, operated);//.ToString();
                else if (mathOperator == "-")
                    visDisplay.Text = Factory.SubtractionOperation(currentAns, operated);//.ToString();
                else if (mathOperator == "x")
                    visDisplay.Text = Factory.MultiplyOperation(currentAns, operated);//.ToString();
                else if (mathOperator == "÷")
                    visDisplay.Text = Factory.DivisionOperation(currentAns, operated);//.ToString();
                reset = true;
                currentAns = visDisplay.Text;
                mathOperator = "";
                operated = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
