namespace WordsGame;

public class Utils
{
    private static Random random = new Random();

    public static string Scramble(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        if (input.Length == 1)
        {
            return input;   
        }

        char[] characters = input.ToCharArray();
        string result;

        do
        {
            for (int i = characters.Length - 1; i > 0; i--)
            {
               int j = random.Next(i + 1);
             (characters[i], characters[j]) = (characters[j], characters[i]);
            }

            result = new string(characters);

        } while (result == input);

        return result;
    }


    public static List<string> SlurpLines(string filePath)
    {
        List<string> words = new();
        foreach (string line in File.ReadLines(filePath))
        {
            words.Add(line.Trim());
        }
        return words;
    }

    public static string PickRandom(List<string> entries)
    {
        var i = new Random().NextInt64() % entries.Count;
        return entries[(int)i];
    }
}