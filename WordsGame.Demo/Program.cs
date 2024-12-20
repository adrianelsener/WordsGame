namespace WordsGame.Demo;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("usage: {0} WORDSFILE", AppDomain.CurrentDomain.FriendlyName);
            return;
        }
        var words = Utils.SlurpLines(args[0]);
        var word = Utils.PickRandom(words).ToUpper();
        var game = new WordsGame();
        var scrambled = game.Start(word);

        Console.WriteLine("This word has been scrambled:");
        Console.WriteLine("\t{0}", scrambled);
        Console.WriteLine("Can you re-order the letters?");

        var solution = Console.ReadLine();
        if (solution != null)
        {
            var points = game.Grade(solution.ToUpper());
            if (points == 0)
            {
                Console.WriteLine("I award you no points, and may God have mercy on your soul.");
            }
            else
            {
                Console.Write("Correct, you got {0} points!", points);
            }
        }
        else
        {
            Console.Write("You didn't even try...");
        }
    }
}