﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Subtract : ISubtract
    {
        /// <summary>
        /// Subtract method performs Subtraction operation on two string of numbers
        /// </summary>
        /// <param name="fistnumberstring"></param>
        /// <param name="seccondNumberString"></param>
        /// <returns>string result of the Subtraction</returns>
        public string SubtractionOperation(string fistnumberstring, string seccondNumberString)
        {
            decimal firstNumber;
            decimal secondNumber;
            bool firstIsValid = decimal.TryParse(fistnumberstring, out firstNumber);
            bool secondIsValid = decimal.TryParse(seccondNumberString, out secondNumber);

            //CHECKS IF A THE VALUES CAN BE PARSED AND THROWS IF IT CAN'T BE PARSED
            if (!firstIsValid || !secondIsValid)
                throw new ArgumentException();
            string answer = Math.Round((firstNumber - secondNumber), 5).ToString();
            if (answer.Length > 15)
                throw new ArgumentOutOfRangeException();
            return answer;
        }
    }
}
