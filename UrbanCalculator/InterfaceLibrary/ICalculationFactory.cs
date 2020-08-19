namespace UrbanCalculator
{
    /// <summary>
    /// DEFINES METHODS TO BE IMPLEMENTED BY CLASSES THAT INHERITS FROM ICalculationFactory
    /// </summary>
    public interface ICalculationFactory
    {
        //DEFINES METHODS TO BE IMPLEMENTED BY CLASSES THAT INHERITS FROM ICalculationFactory
        string DivisionOperation(string first, string second);
        string MultiplyOperation(string first, string second);
        string AdditionOperation(string first, string second);
        string NegationOperation(string first);
        string SubtractionOperation(string first, string second);
    }
}