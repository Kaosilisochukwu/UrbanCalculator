using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Divide : IDivide
    {
        public string divide(string fistnumberstring, string seccondNumberString)
        {
            decimal firstNumber;
            decimal secondNumber;
            bool firstIsValid = decimal.TryParse(fistnumberstring, out firstNumber);
            bool secondIsValid = decimal.TryParse(seccondNumberString, out secondNumber);
            if (!firstIsValid || !secondIsValid)
                throw new ArgumentException();
            if (secondNumber == 0)
                throw new DivideByZeroException();
            string answer = Math.Round((firstNumber / secondNumber), 5).ToString();
            if (answer.Length > 15)
                throw new ArgumentOutOfRangeException();
            return answer;
        }

    }
}
