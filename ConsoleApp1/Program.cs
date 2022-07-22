namespace ConsoleApp1
{
    internal class Program
    {
        public static GameLogic Logic = new GameLogic();

        public static void Main(string[] args)
        {
            Logic.OutputWord();
            Logic.OutputWordLenght();
            while (!Logic.End)
            {
                Console.WriteLine("Print one letter");
                char letter = char.ToLower(Console.ReadKey(true).KeyChar);
                Logic.CheckWord(letter);
            }
            Console.Read();
        }
    }
}