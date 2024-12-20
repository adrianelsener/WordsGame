namespace WordsGame;

public class WordsGame : IWordsGame
{
    private string originalWord;

    public string Start(string word)
    {
        originalWord = word;

        string scrambledWord = Utils.Scramble(word);

        // testing
        // Console.WriteLine("The original word is: " + word);   

        return "The scamlbed word is: " + scrambledWord;
    }

    public int Grade(string solution)
    {
        if (solution == null)
        {
            return 0;
        }

        if (solution.Equals(originalWord))
        {
            int points = originalWord.Length;
            return points;
        }

        return 0;   
    }
}
