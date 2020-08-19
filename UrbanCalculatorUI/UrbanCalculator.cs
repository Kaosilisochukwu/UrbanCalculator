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

        //INITIALIZE VARIABLE TO HOLD THE FACTORY METHODS
        private readonly ICalculationFactory Factory;

        //INIALIZES THE VALUE TO HOLD THE CURRENT MATH OPERATOR
        string mathOperator = "";

        //INITIALIZE THE VARIABLE THAT HOLDS THE RECENT ANSWER AS currentAns 
        //AND THE VALUE TO BE OPERATED UPON AS operated 
        string currentAns, operated;

        //INITIALIZE THE VALUE TO CHECK IF THE SCREEN SHOULD BE RESET
        bool reset = false;

        public UrbanCalculator(ICalculationFactory factory)
        {
           
            InitializeComponent();
            Factory = factory;
        }

        private void numbers(object sender, EventArgs e)
        {
            //ASSIGNS THE SENDER OBJECT TO addDigit
            Button addDigit = (Button)sender;
            try
            {
                //CHECKS IF THE VALUE ON THE SCREEN IS GREATER THAN THE MAXIMUM THAT CAN BE TAKEN AND THROWS IF IT EXCEEDS
                if (visDisplay.Text.Length >= 15)
                {
                    throw new IndexOutOfRangeException();
                }
                //CHECKS IF THE VALUE OF THE DISPLAY IS 0 AND RESETS THE SCREEN
                if (visDisplay.Text == "0")
                    visDisplay.Text = "";
                //CHECKS IF THE VALUE OF reset IS  TRUE, RESETS THE SCREEN AND SET THE VALUE OF reset TO FALSE
                if (reset == true)
                {
                    visDisplay.Text = "";
                    reset = false;
                }
                //CHECK IF THE KEY TYPED IS A DECIMAL VALUE
                if (addDigit.Text == ".")
                {
                    //IF THE INPUT WAS A DECIMAL VALUE,  AND THE SCREEN IS RESET ZERO IS FIRST APPENDED
                    if (visDisplay.Text == "")
                        visDisplay.Text += "0";

                    //IF THE VALUE ON THE SCREEN DOES NOT CONTAIN A PERIOD ALREADY, A PERIOD IS THEN ADDED
                    if (!visDisplay.Text.Contains("."))
                        visDisplay.Text += addDigit.Text;

                    //RESET VALUE IS SET TO FALSE
                    reset = false;
                }
                //CHECKS IF THE OPERATOR IS  EMPTY AND IF THE RESET VALUE IS TRUE
                else if (mathOperator != "" && reset == true)
                {
                    //RESETS THE SCREEN VALUE, APPENDES THE NEW DIGIT TO THE SCREEN VALUE AND SET THE RESET VALUE TO FALSE
                    visDisplay.Text = "";
                    visDisplay.Text += addDigit.Text;
                    reset = false;
                }
                else
                    visDisplay.Text += addDigit.Text;
            }
            catch (Exception ex)
            {
                //CATCHES THE EXCEPTION IF THE NUMBER OF DIGITS ON THE SCREEN EXCEEDS 15 AND SHOW A MESSAGE
                MessageBox.Show("Error: " + ex.Message);
                resetCalculator();
            }       
            //ASSIGNS THE VALUE ON THE DISPLAY SCREEN TO THE VALUE TO BE OPERATED
            operated = visDisplay.Text;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //DELETES THE LAST NUMBER STRING ON THE SCREEN
            if (visDisplay.Text.Length > 1)
                visDisplay.Text = visDisplay.Text.Remove(visDisplay.Text.Length - 1);
            else
                visDisplay.Text = "0";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //CLEARS THE CURRENT VALUE ON THE SCREEN
            visDisplay.Text = "0";
            operated = "0";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //CALLS THE resetCalculator METHOD TO RESET THE CALCULATOR 
            resetCalculator();
        }

        private void operators(object sender, EventArgs e)
        {
            Button currentOperator = (Button)sender;
            try
            {

                //PERFORMS CALCULATIONS BASED ON THE OPERATOR THAT HAS BEEN CLICKED
                if(mathOperator == "x" || mathOperator == "-" || mathOperator == "+" || mathOperator == "÷")
                    visDisplay.Text = Factory.SelectOperation(mathOperator, currentAns, operated);

                //ASSIGNS THE currentAns VARIABLE TO THE VALUE ON THE SCREEN,
                currentAns = visDisplay.Text;

                //UPDATES THE OPERATOR VALUE
                mathOperator = currentOperator.Text;

                //SET THE RESET VALUE TO TRUE
                reset = true;
            }
            catch (Exception ex)
            {
                //CATCHES ANY EXCEPTION AND RESETS THE CALCULATOR
                MessageBox.Show("Error: " + ex.Message);
                resetCalculator();
            }
        }
        /// <summary>
        /// RESETS THE CALCULATOR
        /// </summary>
        void resetCalculator()
        {
            visDisplay.Text = "0";
            mathOperator = "";
            currentAns = "0";
            operated = "0";
        }
        private void NegationBtn_Click(object sender, EventArgs e)
        {
            //NEGATES THE VALUE ON THE SCREEN
           visDisplay.Text = Factory.NegationOperation(visDisplay.Text);

            //ASSIGNS THE VALUE TO THE CURRENT VALUE TO BE OPERATED UPON
            operated = visDisplay.Text;
        }

        private void equaltoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //PERFORMS CALCULATOR OPERATION BASED ON THE MATH OPERATOR
                if (mathOperator == "x" || mathOperator == "-" || mathOperator == "+" || mathOperator == "÷")
                    visDisplay.Text = Factory.SelectOperation(mathOperator, currentAns, operated);

                //SETS THE RESET VALUE TO TRUE, ASSIGNS THE currentAns TO THE VALUE ON THE SCREEN, RESETS THE MATH OPERATOR
                //ASSIGNS THE VALUE OF THE CURRENT VALUE TO BE OPERATED UPON TO 0
                reset = true;
                currentAns = visDisplay.Text;
                mathOperator = "";
                operated = "0";
            }
            catch (Exception ex)
            {
                //CATCHES ANY EXCEPTION AND SHOWS THE MESSAGE ON THE SCREEN
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
