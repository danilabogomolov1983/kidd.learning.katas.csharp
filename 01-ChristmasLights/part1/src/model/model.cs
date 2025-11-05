namespace model;

public enum LightState
{
    ON,
    OFF
}



public record Light(LightState? State = LightState.OFF)
{
    private Light UpdateState(LightState newState) => new (State: newState);

    public Light TurnOn() => UpdateState(LightState.ON);
    public Light TurnOff() => UpdateState(LightState.OFF);
    public Light Toggle() => this?.State == null || this?.State == LightState.OFF ? TurnOn() : TurnOff();
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
public record Grid(GridSize GridSize)
{
    private readonly Light[,] _lights = new Light[GridSize.Width.AsInt(), GridSize.Height.AsInt()];

    
    public Light Get(Point point) => _lights[point.X, point.Y];
}
