namespace modules.Light;

static class LightGenerator
{
    public static LightCreatorEx New => state => new(state);
}