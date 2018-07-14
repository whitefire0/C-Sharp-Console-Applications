using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WordUnscrambler.Data;
using WordUnscrambler.Workers;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        private const string wordListFileName = "wordList.txt";

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
                } while (
                    !continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                    !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueProgram = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueProgram);
        }

        private static void ExecuteScrambledWordsManual()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = manualInput.Split(',');
            DisplayMatchedUnscrambledWords();
        }

        private static void ExecuteScrambledWordsInFile()
        {
            var filename = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambledWords();
        }

        private static void DisplayMatchedUnscrambledWords([]string scrambledWords)
        {
            string[] wordList = _fileReader.Read(wordListFileName);

            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine($"Match found for {matchedWord.ScrambledWord} {matchedWord.Word}");
                }
            }
            else
            {
                Console.WriteLine("No matches have been found.");
            }
        }
    }
}
