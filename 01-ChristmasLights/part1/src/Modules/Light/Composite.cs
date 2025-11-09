namespace modules.Light;

public delegate Light LightCreator();
public delegate Light LightCreatorEx(LightState state);

static class LightCreatorExtensions
{
    public static LightCreator SetState(this LightCreatorEx that, LightState state) => () => that(state);
}
