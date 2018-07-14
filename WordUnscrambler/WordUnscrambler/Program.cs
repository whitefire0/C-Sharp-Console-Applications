using System;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            do
            {
                Console.WriteLine("Please enter the option - M for manual, F for file");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words filename: ");
                        ExecuteScrambledWordsInFile();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually:");
                        ExecuteScrambledWordsManual();
                        break;
                    default:
                        Console.WriteLine("Option was not recognised");
                        break;
                }

                var continueDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue the program? (y/n");
                    continueDecision = (Console.ReadLine().ToUpper() ?? string.Empty);

                } while (!continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueProgram = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueProgram);
        }

        private static void ExecuteScrambledWordsManual()
        {

        }

        private static void ExecuteScrambledWordsInFile()
        {

        }
    }
}
