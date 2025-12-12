public static class GridOperations
{
    extension(Grid source)
    {
        public Action<Point> TurnOn => p =>
        {
            source.Update(p, EToggleState.On);
        };

        public Action<Point> TurnOff => p =>
        {
            source.Update(p, EToggleState.Off);
        };

        public Action<Point> Toggle => p =>
        {
            var light = source.Get(p);
            source.Update(p, light.State == EToggleState.On ? EToggleState.Off : EToggleState.On);
        };

        public Action<Point> Dummy => p =>
        {
            var light = source.Get(p);
            source.Update(p, light.State == EToggleState.On ? EToggleState.Off : EToggleState.On);
        };


        public Func<Point, Point, GridRange> Range => (from, to) => new GridRange(from, to);


    }
}

public record GridRange(Point from, Point to);
public class Grid
{
    private Light[,] Lights;
    public Grid(int width, int height)
    {
        Lights = new Light[width, height];
    }

    public void Update(Point point, EToggleState state)
    {
        var (x, y) = point;
        Lights[x, y] = new Light(state);
    }

    public Light Get(Point point)
    {
        var (x, y) = point;
        return Lights[x, y];
    }
    public void Toggle(int x, int y)
    {
        var light = Lights[x, y];
        Lights[x, y] = new Light(light.State == EToggleState.On ? EToggleState.Off : EToggleState.On);
    }

}



// p ublic class Grid()
// {
//     private IDictionary<Point, Light> Lights = new Dictionary<Point, Light>();

//     public Light Get(Point point) => Lights[point];

//     public TurnOn(Point point)
//     {
//         Lights[point] = new Light(EToggleState.On);
//     }
//     public TurnOff(Point point)
//     {
//         Lights[point] = new Light(EToggleState.Off);
//     }
//}

