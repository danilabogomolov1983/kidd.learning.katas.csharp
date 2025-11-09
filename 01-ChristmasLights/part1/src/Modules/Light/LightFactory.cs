namespace modules.Light;

public class LightFactory
{
    private IDictionary<string, LightCreator> Generators { get; }

    public LightFactory()
    {
        this.Generators = new Dictionary<string, LightCreator>()
        {
            {
                "Default", CreateLightCreator(LightState.Off)
            },
            {
                LightState.Off.ToString(), CreateLightCreator(LightState.Off)
            },
            {
                LightState.On.ToString(), CreateLightCreator(LightState.On)
            }

        };

    }

    public LightCreator GetCreator(string? name = null) 
        => name != null && this.Generators.TryGetValue(name, out var generator) ? generator : DefaultCreator;
    private static LightCreator CreateLightCreator(LightState state) => LightGenerator.New.SetState(state);
    private static LightCreator DefaultCreator => LightGenerator.New.SetState(LightState.Off);

}