using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public class CalculationFactory : ICalculationFactory
    {

        public string DivisionOperation(string first, string second)
        {
            var divider = new Divide();
            return divider.divide(first, second);
        }

        public string MultiplyOperation(string first, string second)
        {
            var multiplier = new Multiply();
            return multiplier.multiply(first, second);
        }

        public string NegationOperation(string first)
        {
            var negator = new Negate();
            return negator.negate(first);
        }

        public string SubtractionOperation(string first, string second)
        {
            var subtractor = new Subtract();
            return subtractor.Subract(first, second);

        }

        public string AdditionOperation(string first, string second)
        {
            var adder = new Add();
            return adder.Addition(first, second);

        }
    }
}
