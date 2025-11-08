using System.Reflection;

using model;

namespace test.model;

public class GridTests
{

    
    [Fact]
    public void GridFactory_SetSize_Create()
    {

        var gridSize = new GridSize(new Width(1000), new Height(1000));
        var createGrid = GridFactory.Create.Apply(gridSize);
        var grid = createGrid();

    }
}
