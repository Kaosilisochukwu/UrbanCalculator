using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    /// <summary>
    /// A collection of operations carried out by a calculator
    /// </summary>
    public class CalculationFactory : ICalculationFactory
    {
        /// <summary>
        /// performs an arithmetic operation based on nte operaror that is clicked
        /// </summary>
        /// <param name="sign"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>String result of the operation</returns>
        public string SelectOperation(string sign, string first, string second)
        {
            string operatedString = string.Empty;
            if (sign == "+")
                operatedString = AdditionOperation(first, second);
            if (sign == "x")
                operatedString = MultiplyOperation(first, second);
            if (sign == "-")
                operatedString = SubtractionOperation(first, second);
            if (sign == "÷")
                operatedString = DivisionOperation(first, second);

            return operatedString;
        }


        /// <summary>
        /// DivisionOperation methid that defines methods for division operation for a calculator
        /// </summary>
        /// <param name="first">Numerator</param>
        /// <param name="second">Denominator</param>
        /// <returns>string quotient</returns>
        public string DivisionOperation(string fistnumberstring, string seccondNumberString)
        {
            decimal firstNumber;
            decimal secondNumber;
            bool firstIsValid = decimal.TryParse(fistnumberstring, out firstNumber);
            bool secondIsValid = decimal.TryParse(seccondNumberString, out secondNumber);

            //CHECKS IF A THE VALUES CAN BE PARSED AND THROWS IF IT CAN'T BE PARSED
            if (!firstIsValid || !secondIsValid)
                throw new ArgumentException();
            //CHECKS FOR ZERO DIVISION
            if (secondNumber == 0)
                throw new DivideByZeroException();

            string answer = Math.Round((firstNumber / secondNumber), 5).ToString();
            if (answer.Length > 15)
                throw new ArgumentOutOfRangeException();
            return answer;
        }

        /// <summary>
        /// MultiplyOperation method that defines methods for multiplication operation for a calculator
        /// </summary>
        /// <param name="first">Numerator</param>
        /// <param name="second">Denominator</param>
        /// <returns>string result of multiplication</returns>
        public string MultiplyOperation(string fistnumberstring, string seccondNumberString)
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

        /// <summary>
        /// Negation method that defines methods for negation operation for a calculator
        /// </summary>
        /// <param name="first">Numerator</param>
        /// <returns>string sign inverse of a value</returns>
        public string NegationOperation(string input) => !decimal.TryParse(input, out decimal decimalNumber) 
                                                ? throw new ArgumentException() : input.Contains("-")
                                                ? input.Remove(0, 1) : "-" + input;

        /// <summary>
        /// Subtraction method that defines methods for subtraction operation for a calculator
        /// </summary>
        /// <param name="first">Numerator</param>
        /// <param name="second">Denominator</param>
        /// <returns>string difference</returns>        
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


    /// <summary>
    /// Addition method that defines methods for addition operation for a calculator
    /// </summary>
    /// <param name="first">Numerator</param>
    /// <param name="second">Denominator</param>
    /// <returns>string sum</returns>
    public string AdditionOperation(string fistnumberstring, string seccondNumberString)
        {
            decimal firstNumber;
            decimal secondNumber;
            bool firstIsValid = decimal.TryParse(fistnumberstring, out firstNumber);
            bool secondIsValid = decimal.TryParse(seccondNumberString, out secondNumber);
            string answer = Math.Round((firstNumber + secondNumber), 5).ToString();
            //CHECKS IF A THE VALUES CAN BE PARSED AND THROWS IF IT CAN'T BE PARSED
            if (!firstIsValid || !secondIsValid)
                throw new ArgumentException();
            if (answer.Length > 15)
                throw new ArgumentOutOfRangeException();

            return answer;
        }
    }
}
