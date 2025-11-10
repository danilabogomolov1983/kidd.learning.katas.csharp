using Modules.Common.Model;

using modules.Light.Model;

namespace Modules.Grid.Model;

public record GridInfo(WidthValue Width, HeightValue Height, LightMatrix Lights);

public record LightMatrix
{
    private static readonly LightType[,] Lights;
    public LightMatrix()
    {
        
    }

};


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
