using model;

namespace test.model;

public class LightTests
{
    [Fact]
    public void DefaultStateIsOff()
    {
        var light = new Light();

        Assert.Equal(LightState.OFF, light.State);
    }

    [Fact]
    public void TurnOnReturnsLightWithOnState()
    {
        var original = new Light(LightState.OFF);

        var turnedOn = original.TurnOn();

        Assert.Equal(LightState.ON, turnedOn.State);
        Assert.Equal(LightState.OFF, original.State);
    }

    [Fact]
    public void TurnOffReturnsLightWithOffState()
    {
        var original = new Light(LightState.ON);

        var turnedOff = original.TurnOff();

        Assert.Equal(LightState.OFF, turnedOff.State);
        Assert.Equal(LightState.ON, original.State);
    }

    [Fact]
    public void ToggleFromNullStateTurnsLightOn()
    {
        var light = new Light(null);

        var toggled = light.Toggle();

        Assert.Equal(LightState.ON, toggled.State);
    }

    [Fact]
    public void ToggleFromOnTurnsLightOff()
    {
        var light = new Light(LightState.ON);

        var toggled = light.Toggle();

        Assert.Equal(LightState.OFF, toggled.State);
    }
}
