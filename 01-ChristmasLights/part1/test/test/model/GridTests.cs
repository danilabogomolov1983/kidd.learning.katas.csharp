using System.Reflection;

using model;

namespace test.model;

public class GridTests
{
    [Fact]
    public void GetReturnsOffLightWhenCellIsUnset()
    {
        var grid = new Grid(new GridSize(new Width(2), new Height(2)));

        var light = grid.Get(new Point(0, 0));

        Assert.NotNull(light);
        Assert.Equal(LightState.Off, light.State);
    }

    [Fact]
    public void GetReturnsStoredLightInstance()
    {
        var grid = new Grid(new GridSize(new Width(2), new Height(2)));
        var lightsField = typeof(Grid).GetField("Lights", BindingFlags.NonPublic | BindingFlags.Instance)
                         ?? throw new InvalidOperationException("Lights field not found on Grid");
        var lights = (Light[,])lightsField.GetValue(grid)!;
        var expected = new Light(LightState.On);

        lights[1, 1] = expected;

        var retrieved = grid.Get(new Point(1, 1));

        Assert.Same(expected, retrieved);
        Assert.Equal(LightState.On, retrieved.State);
    }
}
