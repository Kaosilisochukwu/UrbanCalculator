using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanCalculator
{
    public static class FuncDistributor
    {
        //declared a variable Clone of type ICalculationFactory
        public static ICalculationFactory Clone { get; private set; }

        /// <summary>
        /// Assigns an instance of CalculationFactory to Clone
        /// </summary>
        /// <returns>ICalculationFactory</returns>
        public static ICalculationFactory Store()
        {
            return Clone = new CalculationFactory();
            
        }
    }
}
