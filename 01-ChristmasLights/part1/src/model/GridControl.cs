using model.Types;

public static class GridControlUnit
{
    public static Light GetLight(this Grid that, Point point) => that.Lights[point.X, point.Y];
}