using model.Types;

namespace model.Behavour;

public class GridFactory
{
    private IDictionary<string, GridCreator> Generators { get; }

    public GridFactory()
    {
        this.Generators = new Dictionary<string, GridCreator>()
        {
            {
                "Default", CreateGridCreator(DefaultSize)
            },

            {
                "100_Square", CreateGridCreator(new(new(100), new(100)))
            }
        };

    }
    public GridCreator GetCreator(string? name = null)
        => name != null && this.Generators.TryGetValue(name, out var generator) ? generator : DefaultCreator;

    public GridCreator GetCustomCreator(GridSize gridSize) => GridGenerator.New.SetSize(gridSize);
    private static GridCreator CreateGridCreator(GridSize gridSize) => GridGenerator.New.SetSize(gridSize);
    private static GridSize DefaultSize => new(new(1000), new(1000));
    private static GridCreator DefaultCreator { get; } = GridGenerator.New.SetSize(DefaultSize);

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
