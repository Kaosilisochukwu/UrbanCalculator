using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class Negate : INegate
    {
        public string negate(string input) => "-" + input;
    }
}
