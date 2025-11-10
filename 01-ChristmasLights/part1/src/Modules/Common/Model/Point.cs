namespace Modules.Common.Model;
public record PointValues(int X, int Y);

public static class Point{
    public static PointValues New(int x, int y) => new(x, y);
}