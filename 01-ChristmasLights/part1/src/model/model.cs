namespace model;

public enum LightState
{
    On,
    Off
}



public record Light(LightState? State = LightState.Off)
{
    private static Light UpdateState(LightState newState) => new (State: newState);

    public static Light TurnOn() => UpdateState(LightState.On);
    public static Light TurnOff() => UpdateState(LightState.Off);
    public Light Toggle() => State is null or LightState.Off ? TurnOn() : TurnOff();
}


public static class Extensions
{
    public static int AsInt(this Side that) => that.Value;
}
public record Side(int Value);
public record Width(int Value) : Side(Value);
public record Height(int Value) : Side(Value);
public record GridSize(Width Width, Height Height);
public record Point(int X, int Y);


public delegate Grid SetSize(GridSize gridSize);


public record Grid(GridSize? GridSize = null, Light[,]? Lights = null);

// private readonly Light[,] _lights = new Light[GridSize.Width.AsInt(), GridSize.Height.AsInt()];

// public Light Get(Point point) => _lights[point.X, point.Y];

// public Light[] GetRange(Point point1, Point point2)
// {
//     for (int i = point1.X; i <= point2.X; i++)
//     {
//         for (int k = point1.Y; k <= point2.Y; k++)
//         {
//             // execute f()
//         }
//     }
//     
// }



public delegate Grid GridCreator();
public delegate Grid GridCreatorEx(GridSize gridSize);

public static class GridCreatorExtensions
{
    public static GridCreator Apply(this GridCreatorEx that, GridSize gridSize) => () => that(gridSize);
}
public static class GridFactory
{

    public static GridCreatorEx Create => gridSize => new(gridSize, new Light[gridSize.Width.AsInt(), gridSize.Height.AsInt()]);
    // public static Light[] GetRange(this Grid that, Point point1, Point point2)
    // {
    //     for (int i = point1.X; i <= point2.X; i++)
    //     {
    //         for (int k = point1.Y; k <= point2.Y; k++)
    //         {
    //             // execute f()
    //         }
    //     }

    // } 
}


// public Grid TurnSquareOn(Position left, Position right)
// {
//     for (int i = left.X; i <= right.X; i++)
//     {
//         for (int k = left.Y; k <= right.Y; k++)
//             TurnOn(Position.Create(i, k));
//     }
//     return this;
// }
// public Grid TurnSquareOff(Position left, Position right)
// {
//     for (int i = left.X; i <= right.X; i++)
//     {
//         for (int k = left.Y; k <= right.Y; k++)
//             TurnOff(Position.Create(i, k));
//     }
//     return this;
// }

// public Grid ToggleSquare(Position start, Position end)
// {
//     for (int i = start.X; i <= end.X; i++)
//     {
//         for (int k = start.Y; k <= end.Y; k++)
//             Toggle(Position.Create(i, k));
//     }
//     return this;
// }
