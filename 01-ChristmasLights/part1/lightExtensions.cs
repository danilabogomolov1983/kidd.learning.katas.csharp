public static class LightExtensions
{
	public static Light Toggle(this Light that)
	{
		return that.State != LightState.On ? Light.Create() with { State = LightState.On } : Light.Create();
	}
};
