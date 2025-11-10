namespace modules.Light;

static class LightGenerator
{
    public static CreateLightEx New => state => new(state);
}