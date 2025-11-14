using Xunit;

public class GetScalarIdTests
{
    [Fact]
    public void GetScalarId_WorksForSeveralValues()
    {

        Assert.Equal(1203, Point.New(12, 3).GetScalarId());
        Assert.Equal(12001, Point.New(12, 1).GetScalarId());
        Assert.Equal(1234, Point.New(12, 34).GetScalarId());
        Assert.Equal(12345, Point.New(12, 345).GetScalarId());
        Assert.Equal(14, Point.New(1, 4).GetScalarId());
        Assert.Equal(1234, Point.New(1, 234).GetScalarId());
        Assert.Equal(12344, Point.New(123, 34).GetScalarId());
        Assert.Equal(1234, Point.New(12, 34).GetScalarId());

    }
}