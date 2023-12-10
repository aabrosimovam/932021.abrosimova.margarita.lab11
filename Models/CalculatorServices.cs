namespace _932021.abrosimova.margarita.lab11
{
    public interface ICalculatorDataService
    {
        CalculatorDataModel dataModel { get; }
    }
    public class CalculatorDataService : ICalculatorDataService
    {
        public CalculatorDataModel dataModel => new CalculatorDataModel();
    }
}