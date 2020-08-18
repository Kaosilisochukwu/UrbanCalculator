using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Add : IAdd
    {
        public string Addition(string fistnumberstring, string seccondNumberString)
        {
            decimal firstNumber;
            decimal secondNumber;
            bool firstIsValid = decimal.TryParse(fistnumberstring, out firstNumber);
            bool secondIsValid = decimal.TryParse(seccondNumberString, out secondNumber);
            string answer = Math.Round((firstNumber + secondNumber), 5).ToString();

            if (!firstIsValid || !secondIsValid)
                throw new ArgumentException();
            if (answer.Length > 15)
                throw new ArgumentOutOfRangeException();

            return answer;
        }
    }
}
