using Part1.Domain;
using Part1.Operations;

namespace Test;

public class GridTests
{
    [Fact]
    public void Test_TurnOn()
    {
        var grid = Grid.CreateSquare(10);
        var expectedPoint = new Point(0, 0);
        grid.TurnOn(expectedPoint);
        var actual = grid.Get(expectedPoint);
        Assert.Equal(Light.On, actual);
        Assert.Equal(1, grid.TurnedOnLights());
        Assert.Equal(99, grid.TurnedOffLights());
    }
    
    [Fact]
    public void Test_TurnOff()
    {
        var grid = Grid.CreateSquare(10);
        var expectedPoint = new Point(0, 0);
        grid.TurnOff(expectedPoint);
        var actual = grid.Get(expectedPoint);
        Assert.Equal(Light.Off, actual);
        Assert.Equal(100, grid.TurnedOffLights());
        Assert.Equal(0, grid.TurnedOnLights());
    }
    
    [Fact]
    public void Test_Toggle()
    {
        var grid = Grid.CreateSquare(10);
        var expectedPoint = new Point(0, 0);
        grid.Toggle(expectedPoint);
        var actual = grid.Get(expectedPoint);
        Assert.Equal(Light.On, actual);
        Assert.Equal(1, grid.TurnedOnLights());
        Assert.Equal(99, grid.TurnedOffLights());
    }
    
    [Fact]
    public void Test_TurnOnRange()
    {
        var grid = Grid.CreateSquare(10);
        var expectedPointFrom = new Point(0, 0);
        var expectedPointTo = new Point(9, 9);
        grid.TurnOnRange(expectedPointFrom, expectedPointTo);
        var actualLightFrom = grid.Get(expectedPointFrom);
        var actualLightTo = grid.Get(expectedPointTo);
        Assert.Equal(Light.On, actualLightFrom);
        Assert.Equal(Light.On, actualLightTo);
        
        Assert.Equal(100, grid.TurnedOnLights());
        Assert.Equal(0, grid.TurnedOffLights());
    }
    
    [Fact]
    public void Test_TurnOffRange()
    {
        var grid = Grid.CreateSquare(10);
        var expectedPointFrom = new Point(0, 0);
        var expectedPointTo = new Point(9, 9);
        grid.TurnOffRange(expectedPointFrom, expectedPointTo);
        var actualLightFrom = grid.Get(expectedPointFrom);
        var actualLightTo = grid.Get(expectedPointTo);
        Assert.Equal(Light.Off, actualLightFrom);
        Assert.Equal(Light.Off, actualLightTo);
        
        Assert.Equal(100, grid.TurnedOffLights());
        Assert.Equal(0, grid.TurnedOnLights());
    }
    
    [Fact]
    public void Test_ToggleRange()
    {
        var grid = Grid.CreateSquare(10);
        var expectedPointFrom = new Point(0, 0);
        var expectedPointTo = new Point(9, 9);
        grid.ToggleRange(expectedPointFrom, expectedPointTo);
        var actualLightFrom = grid.Get(expectedPointFrom);
        var actualLightTo = grid.Get(expectedPointTo);
        Assert.Equal(Light.On, actualLightFrom);
        Assert.Equal(Light.On, actualLightTo);
        
        Assert.Equal(100, grid.TurnedOnLights());
        Assert.Equal(0, grid.TurnedOffLights());
    }
}
