namespace Modules.Common.Model;
public record HeightValue(int Value) : Side(Value);

public static class Height
{
    public static HeightValue New(int value) => new(value);
}