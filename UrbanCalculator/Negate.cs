using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Negate : INegate
    {
        public string negate(string input) => !decimal.TryParse(input, out decimal decimalNumber) 
                                                ? throw new ArgumentException() : input.Contains("-")
                                                ? input.Remove(0, 1) : "-" + input;
    }
}
