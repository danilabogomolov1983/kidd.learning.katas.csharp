using System.Reflection;

using model;
using model.Behavour;
using model.Types;

namespace test.model;

public class GridTests
{

    
    [Fact]
    public void GridFactory_SetSize_Create()
    {
        // Arrange
        var factory = new GridFactory();
        var gridCreator = factory.GetCreator();

        // Act
        var grid = gridCreator();

        // Assert

        Assert.Equal(1000, grid.GridSize.Height.AsInt());
        Assert.Equal(1000, grid.GridSize.Height.AsInt());

    }
}
