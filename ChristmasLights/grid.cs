public class Grid
{
    public int[,] lights;

    public Grid(int width, int height)
    {
        lights = new int[width, height];
    }
    
    public Grid TurnOn((int x, int y) start, (int x, int y) end)
    {
        for (int i = start.x; i <= end.x; i++)
        {
            for (int k = start.y; k <= end.y; k++)
            {
                this.lights[i, k] = 1;
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
                this.lights[i, k] = 0;
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
                this.lights[i, k] = this.lights[i, k] == 0 ? 1 : 0;
            }
        }
        return this;
    }

    public int Calculate()
    {
        return lights.Cast<int>().Sum();
    }
}
