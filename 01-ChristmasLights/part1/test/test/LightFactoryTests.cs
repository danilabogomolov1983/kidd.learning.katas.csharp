using System.Reflection;

using model;
using model.Behavour;
using model.Types;

namespace test.model;

public class LightFactoryTests
{


    [Fact]
    public void LightFactory_LightCreator_Default()
    {
        // Arrange
        var factory = new LightFactory();
        var lightCreator = factory.GetCreator();

        // Act
        var light = lightCreator();

        // Assert

        Assert.Equal(new Light(), light);
    }

       [Fact]
    public void LightFactory_LightCreator_On()
    {
        // Arrange
        var factory = new LightFactory();
        var lightCreator = factory.GetCreator("On");

        // Act
        var light = lightCreator();

        // Assert

        Assert.Equal(new Light(LightState.On), light);
    }
}
