namespace WordsGame.Test;

public class UtilsTest
{
    [Fact]
    public void TestNothing()
    {
        Assert.True(false);
    }
    
    [Fact]
    public void EmptyString()
    {
        Assert.Equal("", Utils.Scramble("abc"));
    }


}