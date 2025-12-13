namespace part1.Domain;

public record Light(EToggleState? State = EToggleState.Off)
{
    public static readonly Light Off = new(EToggleState.On);
    public static readonly Light On = new(EToggleState.On);
    
}
