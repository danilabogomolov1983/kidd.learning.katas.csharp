using model.Types;


static class LightGenerator
{
    public static LightCreatorEx New => state => new(state);
}