using Xunit;

public class IntegerToolTests
{
    [Fact]
    public void DigitsCount_WorksForSeveralValues()
    {
        Assert.Equal(1, 0.DigitsCount());
        Assert.Equal(1, 5.DigitsCount());
        Assert.Equal(2, 10.DigitsCount());
        Assert.Equal(2, 12.DigitsCount());
        Assert.Equal(3, 100.DigitsCount());
        Assert.Equal(2, 29.DigitsCount());
        Assert.Equal(3, 999.DigitsCount());
        Assert.Equal(3, 999.DigitsCount());
        Assert.Equal(4, 9999.DigitsCount());
        Assert.Equal(5, 99999.DigitsCount());
        Assert.Equal(6, 999999.DigitsCount());
        Assert.Equal(7, 9999999.DigitsCount());
        Assert.Equal(10, 1000000000.DigitsCount());

    }
    
}