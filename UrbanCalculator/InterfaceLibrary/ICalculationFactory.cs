namespace UrbanCalculator
{
    /// <summary>
    /// DEFINES METHODS TO BE IMPLEMENTED BY CLASSES THAT INHERITS FROM ICalculationFactory
    /// </summary>
    public interface ICalculationFactory : IAdd, ISubtract, IDivide, IMultiply, INegate
    {
        new
                //DEFINES METHODS TO BE IMPLEMENTED BY CLASSES THAT INHERITS FROM ICalculationFactory
                string DivisionOperation(string first, string second);
        new string MultiplyOperation(string first, string second);
        new string AdditionOperation(string first, string second);
        new string NegationOperation(string first);
        new string SubtractionOperation(string first, string second);
        string SelectOperation(string sign, string first, string second);
    }
}