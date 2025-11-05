using model;

namespace test.model;

public class DimensionRecordTests
{
    [Fact]
    public void WidthAndHeightPreserveValues()
    {
        var width = new Width(3);
        var height = new Height(5);

        Assert.Equal(3, width.Value);
        Assert.Equal(5, height.Value);
    }

    [Fact]
    public void GridSizeStoresWidthAndHeightInstances()
    {
        var width = new Width(6);
        var height = new Height(9);

        var gridSize = new GridSize(width, height);

        Assert.Same(width, gridSize.Width);
        Assert.Same(height, gridSize.Height);
    }

    [Fact]
    public void PointStoresCoordinates()
    {
        var point = new Point(4, 8);

        Assert.Equal(4, point.X);
        Assert.Equal(8, point.Y);
    }
}
