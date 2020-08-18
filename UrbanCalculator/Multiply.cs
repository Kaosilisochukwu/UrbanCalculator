using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Multiply : IMultiply
    {
        public string multiply(string fistnumberstring, string seccondNumberString)
        {
            string answer;
            decimal firstNumber;
            decimal secondNumber;
            bool firstIsValid = decimal.TryParse(fistnumberstring, out firstNumber);
            bool secondIsValid = decimal.TryParse(seccondNumberString, out secondNumber);
                if (!firstIsValid || !secondIsValid)
                    throw new ArgumentException();
                answer = Math.Round((firstNumber * secondNumber), 5).ToString();
                if (answer.Length > 15)
                    throw new ArgumentOutOfRangeException("Calcution must not be more than 15 digits");     
            return answer;
        }

    }
}
