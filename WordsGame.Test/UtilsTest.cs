namespace WordsGame.Test;

public class UtilsTest
{
    [Fact]
    public void EmptyString()
    {
        string input = "";
        string result = Utils.Scramble(input);

        Assert.Equal("", result);
    }

    [Fact]
    public void OneLetter()
    {
        string input = "X";
        string result = Utils.Scramble(input);

        Assert.Equal("X", result);
    }

    [Fact]
    public void TwoLetters()
    {
        string input = "XY";
        string result = Utils.Scramble(input);

        Assert.NotEqual(input, result);
        Assert.Equal(input.OrderBy(c => c), result.OrderBy(c => c));
    }

    [Fact]
    public void MultipleLetters()
    {
        string input = "XYZ";
        string result = Utils.Scramble(input);

        Assert.NotEqual(input, result);
        Assert.Equal(input.OrderBy(c => c), result.OrderBy(c => c));
    }
}