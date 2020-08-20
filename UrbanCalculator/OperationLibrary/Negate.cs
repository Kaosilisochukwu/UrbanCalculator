using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Negate : INegate
    {
        /// <summary>
        /// nagete operator reverses the sign of a string of number
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String of the revered sign</returns>
        public string NegationOperation(string input) => !decimal.TryParse(input, out decimal decimalNumber) 
                                                ? throw new ArgumentException() : input.Contains("-")
                                                ? input.Remove(0, 1) : "-" + input;
    }
}
