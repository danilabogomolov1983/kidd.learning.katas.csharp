using System.Data;

public enum LightState { On, Off };

public record X(int Value);
public record Y(int Value);

public record Position(X X, Y Y)
{
    public static Position Create(X X,Y Y) => new(X, Y);
};

public delegate Light Toggle(Light input);

public delegate Light TurnOn(Light input);

public delegate Light TurnOff(Light input);

public record Light(LightState? State = LightState.Off)
{
    public static Light Create() => new();

    // public static Light Toggle()
    // {
    //     return that?.State == null || that.State == LightState.Off ? Light.Create() with { State = LightState.On } : Light.Create();
    // }

    // public static Light TurnOn(this Light _)
    // {
    //     return Light.Create() with { State = LightState.On };
    // }

    // public static Light TurnOff(this Light _)
    // {
    //     return Light.Create();
    // }

};

public record LightTurnedOn: Light(LightState.On);
public record LightTurnedOff: Light(LightState.Off);


public static class LightFactory
{
    public static Func<LightState, Light> New = s => new Light(s);
    public static Func<Light> TurnOn = _ => new LightTurnedOn();
    public static Func<Light> TurnOff = _ => new LightTurnedOff();

}

public record Width(int Value);
public record Height(int Value);

public record GridSize(Width Width, Height Height)
{
    public static GridSize Rectangle(Width width, Height height) => new(width, height);

};

public delegate Grid NewEx(GridSize size);
public delegate Grid New();

public static class GridNewExtension
{
    public static New Apply(this NewEx that, GridSize size) => that(size);
}
public static class GridFactory()
{
    // public static Func<Grid> New(GridSize size) => new Grid(size);

    public static NewEx GridGenerator;
}

public record Grid(GridSize Size)
{
    private Light[,] lights = new Light[Size.Width.Value, Size.Height];

    // public Grid TurnOn(Position position)
    // {
    //     this.lights[position.X, position.Y] = lights[position.X, position.Y].TurnOn();
    //     return this;
    // }
    // public Grid TurnOff(Position position)
    // {
    //     this.lights[position.X, position.Y] = lights[position.X, position.Y].TurnOff();
    //     return this;
    // }
    // public Grid Toggle(Position position)
    // {
    //     this.lights[position.X, position.Y] = lights[position.X, position.Y].Toggle();
    //     return this;
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

    // public int Calculate()
    // {
    //     return lights.Cast<Light>().Count(i => i?.State != null && i.State == LightState.On);
    // }
}
