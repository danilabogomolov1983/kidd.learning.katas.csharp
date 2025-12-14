namespace Part1.Domain;

public class Grid
{
    public static Func<int, int, Grid> Create => (width, height) => new Grid(width, height);
    public static Func<int, Grid> CreateSquare => (sideLength) => new Grid(sideLength, sideLength);
    
    private Light[,] Lights;

    private Grid(int width, int height)
    {
        Lights = new Light[width, height];
    }

    public void Update(Point point, Light light)
    {
        var (x, y) = point;
        Lights[x, y] = light;
    }

    public Light Get(Point point)
    {
        var (x, y) = point;
        return Lights[x, y];
    }
}
