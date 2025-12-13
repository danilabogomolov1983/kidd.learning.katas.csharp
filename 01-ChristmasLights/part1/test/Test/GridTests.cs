using part1.Domain;

namespace Test;

public class GridTests
{
    [Fact]
    public void Test_TurnOn()
    {
        var grid = Grid.CreateSquare(10);
        grid.TurnOn(new Point(0, 0));
        Assert.Equal(Light.On, grid.Get(new Point(0, 0)));
    }
    
    [Fact]
    public void Test_TurnOff()
    {
        var grid = Grid.CreateSquare(10);
        grid.TurnOff(new Point(0, 0));
        Assert.Equal(Light.Off, grid.Get(new Point(0, 0)));
    }
    
    [Fact]
    public void Test_Toggle()
    {
        var grid = Grid.CreateSquare(10);
        grid.Toggle(new Point(0, 0));
        Assert.Equal(Light.On, grid.Get(new Point(0, 0)));
    }
}
