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


using Modules.Common;

using modules.Light.Model;

namespace Modules.Grid;

internal static class GridGenerator
{

    public static CreateGridEx New => (widthValue, heightValue) => new(widthValue, heightValue, new LightType[widthValue.AsInt(), heightValue.AsInt()]);
    
    
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
