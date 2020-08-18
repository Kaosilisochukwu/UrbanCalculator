using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public static class FuncDistributor
    {
        public static ICalculationFactory IClone { get; private set; }

        public static ICalculationFactory Store()
        {
            CalculationFactory store = new CalculationFactory();
            return IClone = store;
        }
    }
}
