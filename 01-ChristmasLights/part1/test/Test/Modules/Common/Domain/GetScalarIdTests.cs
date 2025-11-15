using System.Diagnostics;
using System.Xml.Schema;

using Xunit;

public class GetScalarIdTests
{
    [Fact]
    public void GetScalarId_WorksForSeveralValues()
    {
        Assert.Equal(123, Point.New(12, 3).GetScalarId(1));
        Assert.Equal(121, Point.New(1, 21).GetScalarId(2));
        Assert.Equal(1234, Point.New(12, 34).GetScalarId(2));
        Assert.Equal(12345, Point.New(12, 345).GetScalarId(3));
        Assert.Equal(121345, Point.New(121, 345).GetScalarId(3));
        Assert.Equal(121345, Point.New(12, 1345).GetScalarId(4));
    }

    [Fact]
    public void GetScalarId_AreAnyDuplicateInRange()
    {
        int width = 100;
        int height = 100;

        var actualPoints = Enumerable.Range(0, width)
                        .Select(x => Enumerable.Range(0, height)
                                    .Select(y => Point.New(x, y).GetScalarId(height.DigitsCount())))
                        
                    .SelectMany(i => i);

        var expectedPointsCount = width * height;
        Assert.Equal(expectedPointsCount, actualPoints.Count());

        var grouped = actualPoints.GroupBy(i => i).Select(g => new { Id = g, Sum = g.Sum() });
        Debug.WriteLine(grouped);

        Assert.Equal(0, grouped.Count(i => i.Sum > 1));
    }
}