using Part2.Domain;
using Part2.Operations;

namespace Test;

public class GridTests
{
    
    [Fact]
    public void Test_TotalBrightness()
    {
        var grid = Grid.CreateSquare(10);
        var expectedPointFrom = new Point(0, 0);
        var expectedPointTo = new Point(0, 0);
        grid.TurnOnRange(expectedPointFrom, expectedPointTo);
        Assert.Equal(1, grid.TotalBrightness());
    }
}
