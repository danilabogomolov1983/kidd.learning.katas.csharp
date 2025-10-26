#load "lightExtensions.cs"

public enum LightState { On, Off };

public record Position(int X, int Y)
{
	public static Position Create(int X, int Y) => new(X, Y);
};

public record Light(LightState? State = LightState.Off)
{
    public static Light Create() => new ();
};


public record Grid(int Width, int Height)
{
    private Light[,] lights = new Light[Width, Height];

    public Grid TurnOn(Position position)
    {
        this.lights[position.X, position.Y] = lights[position.X, position.Y].TurnOn();
        return this;
    }
    public Grid TurnOff(Position position)
    {
        this.lights[position.X, position.Y] = lights[position.X, position.Y].TurnOff();
        return this;
    }
    public Grid Toggle(Position position)
    {
        this.lights[position.X, position.Y] = lights[position.X, position.Y].Toggle();
        return this;
    }
    public Grid TurnSquareOn(Position left, Position right)
    {
        for (int i = left.X; i <= right.X; i++)
        {
            for (int k = left.Y; k <= right.Y; k++)
                TurnOn(Position.Create(i, k));
        }
        return this;
    }
    public Grid TurnSquareOff(Position left, Position right)
    {
        for (int i = left.X; i <= right.X; i++)
        {
            for (int k = left.Y; k <= right.Y; k++)
                TurnOff(Position.Create(i, k));
        }
        return this;
    }

    public Grid ToggleSquare(Position start, Position end)
    {
        for (int i = start.X; i <= end.X; i++)
        {
            for (int k = start.Y; k <= end.Y; k++)
                Toggle(Position.Create(i, k));
        }
        return this;
    }

    public int Calculate()
    {
        return lights.Cast<Light>().Count(i => i?.State != null && i.State == LightState.On);
    }
}
