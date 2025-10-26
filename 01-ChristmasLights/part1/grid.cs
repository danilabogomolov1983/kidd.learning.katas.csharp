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

public record Grid(int width, int height)
{
    private Light[,] lights = new Light[width, height];

    public Grid TurnOn(Position start, Position end)
    {
		
		void Loop(Light[,] lights, Position actual)
		{
			(actual.X, actual.Y) switch
			{
				(>=start.X and <=end.X, >=start.Y and <=end.Y) => 
				{
					lights[actual.X, actual.Y].TurnOn();
				},
				_ => return;
			};
		} 

        for (int i = start.X; i <= end.X; i++)
        {
            for (int k = start.Y; k <= end.Y; k++)
            {
                this.lights[i, k] = lights[i, k].TurnOn();
            }
        }
        return this;
    }
    
    public Grid TurnOff(Position start, Position end)
    {
        for (int i = start.X; i <= end.X; i++)
        {
            for (int k = start.Y; k <= end.Y; k++)
            {
                this.lights[i, k] = lights[i, k].TurnOff();
            }
        }
        return this;
    }
    
    public Grid Toggle(Position start, Position end)
    {
        for (int i = start.X; i <= end.X; i++)
        {
            for (int k = start.Y; k <= end.Y; k++)
            {
                this.lights[i, k] = this.lights[i, k].Toggle();
            }
        }
        return this;
    }

    public int Calculate()
    {
        return lights.Cast<Light>().Count(i => i?.State != null && i.State == LightState.On);
    }
}
