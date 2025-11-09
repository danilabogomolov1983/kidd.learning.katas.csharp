using System.Reflection;

using model;
using model.Behavour;
using model.Types;

namespace test.model;

public class GridFactoryTests
{


    [Fact]
    public void GridFactory_GridCreator()
    {
        // Arrange
        var factory = new GridFactory();
        var gridCreator = factory.GetCreator();

        // Act
        var grid = gridCreator();

        // Assert

        Assert.Equal(new GridSize(new(1000), new(1000)), grid.GridSize);
    }
    
        [Fact]
    public void GridFactory_GridCreator_GetCustomCreator()
    {
        // Arrange
        var factory = new GridFactory();
        var expectedGridSize = new GridSize(new(500), new(500));
        var gridCreator = factory.GetCustomCreator(expectedGridSize);

        // Act
        var grid = gridCreator();

        // Assert

        Assert.Equal(expectedGridSize, grid.GridSize);
    }
}
