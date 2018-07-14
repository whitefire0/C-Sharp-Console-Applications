using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Input Converter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNumer, secondNumber);
            Console.WriteLine(result);
        }
    }

    public class InputCoverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
            if(!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value");
            {
                return convertedNumber;
            }
        }
    }
}
