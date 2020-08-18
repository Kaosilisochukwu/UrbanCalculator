namespace UrbanCalculator
{
    public interface ICalculationFactory
    {
        string DivisionOperation(string first, string second);
        string MultiplyOperation(string first, string second);
        string AdditionOperation(string first, string second);
        string NegationOperation(string first);
        string SubtractionOperation(string first, string second);
    }
}