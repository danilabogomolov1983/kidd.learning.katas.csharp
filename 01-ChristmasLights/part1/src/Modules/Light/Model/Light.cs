namespace modules.Light.Model;
public record LightType(LightStateValue StateValue);

public static class Light
{
    public static LightType New() => new(LightStateValue.Off);
}

// {
    // private static Light UpdateState(LightState newState) => new(State: newState);

    // public static Light TurnOn() => UpdateState(LightState.On);
    // public static Light TurnOff() => UpdateState(LightState.Off);
    // public Light Toggle() => State is null or LightState.Off ? TurnOn() : TurnOff();
// }


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
