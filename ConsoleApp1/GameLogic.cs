namespace ConsoleApp1
{
    public class GameLogic
    {
        public byte FailAttemp { get; set; }
        public byte MaxTry { get; }
        public string WordToFind { get; set; }
        public bool HasLost { get; set; }
        public bool HaveWin { get; set; }
        public bool End { get; set; }
        public List<char> LetterFound { get; set; }
        public GameLogic()
        {
            LetterFound = new List<char>();
            MaxTry = 5;
            WordToFind = "manger".ToLower();
        }

        public void OutputWord()
        {
            string outputWordFinal = string.Empty;
            for (byte i = 0; i != WordToFind.Length; i++)
            {
                if (LetterFound.Contains(WordToFind[i]))
                {
                    outputWordFinal += WordToFind[i];
                }
                else
                {
                    outputWordFinal += " _";
                }
            }
            Console.WriteLine(outputWordFinal);
        }
        public void OutputWordLenght()
        {
            Console.WriteLine("The words containt {0} letter", WordToFind.Length);
        }

        public void CheckWord(char e)
        {
            bool returnOutput = WordToFind.Contains(e);
            if (returnOutput)
            {
                if (!LetterFound.Contains(e))
                {
                    LetterFound.Add(e);
                    Console.WriteLine("good letter");
                    OutputWord();
                }

                if (LetterFound.Count == WordToFind.Length)
                {
                    Console.WriteLine("Congratulation you found the Word");
                    OutputWord();
                    End = true;
                    HaveWin = true;
                }
                return;
            }

            FailAttemp++;
            if (FailAttemp >= MaxTry)
            {
                HasLost = true;
                End = true;
                Console.WriteLine("loser you lost");
            }
            Console.WriteLine($"wrong letter, you have {MaxTry - FailAttemp} left try");
            OutputWord();
        }
    }
}