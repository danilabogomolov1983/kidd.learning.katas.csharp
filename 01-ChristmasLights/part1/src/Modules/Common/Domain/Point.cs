public record PointCoordinates(int X, int Y);

public static class Point
{
    public static PointCoordinates New(int x, int y) => new(x, y);


    extension(PointCoordinates source)
    {
        
        public Func<int, int> GetScalarId => rank => source.X * ((int)Math.Pow(10, rank))  + source.Y;
    }
}

