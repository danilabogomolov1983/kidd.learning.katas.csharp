#load "model.csx"

public static Light Toggle(this Light that)
{
	return that?.State == null || that.State == LightState.Off ? Light.Create() with { State = LightState.On } : Light.Create();
}

public static Light TurnOn(this Light _)
{
	return Light.Create() with { State = LightState.On };
}

public static Light TurnOff(this Light _)
{
	return Light.Create();
}
