using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public static class FuncDistributor
    {
        //declared a variable Clone of type ICalculationFactory and assigns it to an instance of of CalculationFactory
        public static ICalculationFactory Clone { get; private set; } = new CalculationFactory();


    }
}
