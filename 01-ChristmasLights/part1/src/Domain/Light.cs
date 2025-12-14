namespace Part1.Domain;

public record Light(EToggleState? State = EToggleState.Off)
{
    public static readonly Light Off = new(EToggleState.Off);
    public static readonly Light On = new(EToggleState.On);
    
}
