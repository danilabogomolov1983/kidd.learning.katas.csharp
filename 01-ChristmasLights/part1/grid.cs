
public enum LightState { On, Off };

public record Light(LightState? State = LightState.Off)
{
    public static Light Create() => new ();
};

public static class LightExtensions
{
	public static Light Toggle(this Light that)
	{
		return that.State != LightState.On ? Light.Create() with { State = LightState.On } : Light.Create();
	}
};


public class Grid
{
    private Light[,] lights;

    public Grid(int width, int height)
    {
        lights = new Light[width, height];
    }
    
    public Grid TurnOn((int x, int y) start, (int x, int y) end)
    {
        for (int i = start.x; i <= end.x; i++)
        {
            for (int k = start.y; k <= end.y; k++)
            {
                this.lights[i, k] = Light.Create() with { State = LightState.On };
            }
        }
        return this;
    }
    
    public Grid TurnOff((int x, int y) start, (int x, int y) end)
    {
        for (int i = start.x; i <= end.x; i++)
        {
            for (int k = start.y; k <= end.y; k++)
            {
                this.lights[i, k] = Light.Create();
            }
        }
        return this;
    }
    
    public Grid Toggle((int x, int y) start, (int x, int y) end)
    {
        for (int i = start.x; i <= end.x; i++)
        {
            for (int k = start.y; k <= end.y; k++)
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
