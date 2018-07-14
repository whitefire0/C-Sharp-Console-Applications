using System;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;
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

                var continueWordUnscrambleDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue the program? (y/n");
                    continueWordUnscrambleDecision = (Console.ReadLine().ToUpper() ?? string.Empty);

                } while (!continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueWordUnscrambleDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambledWordsManual()
        {
            throw new NotImplementedException();
        }

        private static void ExecuteScrambledWordsInFile()
        {
            throw new NotImplementedException();
        }
    }
}
