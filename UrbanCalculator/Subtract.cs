using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Subtract : ISubtract
    {
        public string Subract(string fistnumberstring, string seccondNumberString)
        {
            decimal firstNumber;
            decimal secondNumber;
            bool firstIsValid = decimal.TryParse(fistnumberstring, out firstNumber);
            bool secondIsValid = decimal.TryParse(seccondNumberString, out secondNumber);
            if (!firstIsValid || !secondIsValid)
                throw new ArgumentException();
            string answer = Math.Round((firstNumber - secondNumber), 5).ToString();
            if (answer.Length > 15)
                throw new ArgumentOutOfRangeException();
            return answer;
        }
    }
}
