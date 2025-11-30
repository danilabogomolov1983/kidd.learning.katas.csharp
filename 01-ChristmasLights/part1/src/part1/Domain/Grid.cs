public record Grid(int Count, IList<Cell> Cells);


public static class GridFactory
{
    static Func<int, Grid> New => count => new Grid(count, []);

    extension(Grid source)
    {
        static Cell Get(Coordinates c) {
            return source.Cells.Contains(cell => cell); 
        }
    }

}
// public class Grid()
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

