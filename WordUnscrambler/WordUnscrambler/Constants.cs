namespace WordUnscrambler
{
    public class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords ="Enter scrambed word(s) manually or as a file: F - file/M - manual";
        public const string OptionsOnContinuingTheProgram = "Would you like to continue? y/n";

        public const string EnterScrambledWordsViaFile = "Enter filename (must be in the exe root folder): ";
        public const string EnterScrambledWordsManually = "Enter word(s) manually (seperated by commas if multiple): ";
        public const string EnterScrambledWordsOptionNotRecognised = "The option was not recognised";

        public const string ErrorScrambledWordsCannotBeloaded = "Scrambled words cannot be loaded as there was an error: ";
        public const string ErrorProgramWillBeTerminated = "The program will now be terminated.";

        public const string MatchFound = "MATCH FOUND FOR {0}: {1}";
        public const string MatchNotFound = "No matches have been found.";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordList.txt";

    }
}