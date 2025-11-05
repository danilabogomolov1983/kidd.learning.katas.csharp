using model;

namespace test.model;

public class LightTests
{
    [Fact]
    public void DefaultStateIsOff()
    {
        var light = new Light();

        Assert.Equal(LightState.Off, light.State);
    }

    [Fact]
    public void TurnOnReturnsLightWithOnState()
    {
        var original = new Light(LightState.Off);

        var turnedOn = Light.TurnOn();

        Assert.Equal(LightState.On, turnedOn.State);
        Assert.Equal(LightState.Off, original.State);
    }

    [Fact]
    public void TurnOffReturnsLightWithOffState()
    {
        var original = new Light(LightState.On);

        var turnedOff = Light.TurnOff();

        Assert.Equal(LightState.Off, turnedOff.State);
        Assert.Equal(LightState.On, original.State);
    }

    [Fact]
    public void ToggleFromNullStateTurnsLightOn()
    {
        var light = new Light(null);

        var toggled = light.Toggle();

        Assert.Equal(LightState.On, toggled.State);
    }

    [Fact]
    public void ToggleFromOnTurnsLightOff()
    {
        var light = new Light(LightState.On);

        var toggled = light.Toggle();

        Assert.Equal(LightState.Off, toggled.State);
    }
}
