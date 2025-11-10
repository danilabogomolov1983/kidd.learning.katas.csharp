using modules.Light.Model;

namespace modules.Light;

public delegate LightType CreateLight();
public delegate LightType CreateLightEx(LightStateValue state);

static class LightCreatorExtensions
{
    public static CreateLight SetState(this CreateLightEx that, LightStateValue state) => () => that(state);
}
