namespace Modules.Common.Model;

public record WidthValue(int Value): Side(Value);
public static class Width
{
    public static WidthValue New(int value) => new(value);
}
