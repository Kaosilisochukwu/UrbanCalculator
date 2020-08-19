﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Multiply : IMultiply
    {
        /// <summary>
        /// multiply method performs multiplication operation on two string of numbers
        /// </summary>
        /// <param name="fistnumberstring"></param>
        /// <param name="seccondNumberString"></param>
        /// <returns>string result of the multiplication</returns>
        public string multiply(string fistnumberstring, string seccondNumberString)
        {
            string answer;
            decimal firstNumber;
            decimal secondNumber;
            bool firstIsValid = decimal.TryParse(fistnumberstring, out firstNumber);
            bool secondIsValid = decimal.TryParse(seccondNumberString, out secondNumber);

            //CHECKS IF A THE VALUES CAN BE PARSED AND THROWS IF IT CAN'T BE PARSED
            if (!firstIsValid || !secondIsValid)
                    throw new ArgumentException();
                answer = Math.Round((firstNumber * secondNumber), 5).ToString();
                if (answer.Length > 15)
                    throw new ArgumentOutOfRangeException("Calcution must not be more than 15 digits");     
            return answer;
        }

    }
}