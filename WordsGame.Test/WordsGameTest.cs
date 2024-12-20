namespace WordsGame.Test;

public class WordsGameTest
{
    [Fact]
    public void TestGradeCorrectSolution()
    {
        string input = "ABCDEFG";
        string solution = "ABCDEFG";

        WordsGame game = new WordsGame();
        game.Start(input);

        int grade = game.Grade(solution);

        Assert.Equal(input.Length, grade);
    }

    [Fact]
    public void TestGradeIncorrectSolution()
    {
        string input = "ABCDEFG";
        string solution = "GFEDCBA";

        WordsGame game = new WordsGame();
        game.Start(input);

        int grade = game.Grade(solution);

        Assert.Equal(0, grade);
    }

    [Fact]
    public void TestGradeNullSolution()
    {
        string input = "ABCDEFG";

        WordsGame game = new WordsGame();
        game.Start(input);

        int grade = game.Grade(null);

        Assert.Equal(0, grade);
    }
}