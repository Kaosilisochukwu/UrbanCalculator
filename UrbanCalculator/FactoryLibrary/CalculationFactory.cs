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
        public string DivisionOperation(string first, string second)
        {
            var divider = new Divide();
            return divider.divide(first, second);
        }
        /// <summary>
        /// MultiplyOperation method that defines methods for multiplication operation for a calculator
        /// </summary>
        /// <param name="first">Numerator</param>
        /// <param name="second">Denominator</param>
        /// <returns>string result of multiplication</returns>
        public string MultiplyOperation(string first, string second)
        {
            var multiplier = new Multiply();
            return multiplier.multiply(first, second);
        }

        /// <summary>
        /// Negation method that defines methods for negation operation for a calculator
        /// </summary>
        /// <param name="first">Numerator</param>
        /// <returns>string sign inverse of a value</returns>
        public string NegationOperation(string first)
        {
            var negator = new Negate();
            return negator.negate(first);
        }

        /// <summary>
        /// Subtraction method that defines methods for subtraction operation for a calculator
        /// </summary>
        /// <param name="first">Numerator</param>
        /// <param name="second">Denominator</param>
        /// <returns>string difference</returns>
        public string SubtractionOperation(string first, string second)
        {
            var subtractor = new Subtract();
            return subtractor.Subract(first, second);

        }

        /// <summary>
        /// Addition method that defines methods for addition operation for a calculator
        /// </summary>
        /// <param name="first">Numerator</param>
        /// <param name="second">Denominator</param>
        /// <returns>string sum</returns>
        public string AdditionOperation(string first, string second)
        {
            var adder = new Add();
            return adder.Addition(first, second);

        }
    }
}
