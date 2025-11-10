using modules.Light.Model;

namespace modules.Light;

public class LightFactory
{
    public static CreateLightEx New() => LightGenerator.New;
    private static CreateLight Default => LightGenerator.New.SetState(LightStateValue.Off);

}
