using modules.Grid.Model;
using modules.Light.Model;

public static class GridControlUnit
{
    public static Light GetLight(this Grid that, Point point) => that.Lights[point.X, point.Y];

    public static Light[,] GetRange(this Grid that, Point from, Point till) => that.Lights;
}