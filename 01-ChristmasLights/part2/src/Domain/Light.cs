using System.ComponentModel.Design.Serialization;

namespace Part2.Domain;

public record Brightness(int Value = 0)
{
    public static readonly Brightness Default = new Brightness(0);
};

public record Light(EToggleState? State = EToggleState.Off, Brightness? Brightness = null)
{
    public static readonly Light Off = new() { Brightness = Brightness.Default };
    public static readonly Light On = new(EToggleState.On,  Brightness.Default.IncreaseByOne());
}

public static class LightExtensions
{
    extension(Light source)
    {
        public Func<Light> TurnOn => () => new Light(EToggleState.On, source.Brightness.IncreaseByOne());
        public Func<Light> TurnOff => () => new Light(EToggleState.Off, source.Brightness.DecreaseByOne());
        public Func<Light> Toggle => () => new Light(source.State == EToggleState.On ? EToggleState.Off : EToggleState.On, source.Brightness.Increase(2));
    }
}

public static class BrightnessExtensions
{
    extension(Brightness source)
    {
        public Func<Brightness> IncreaseByOne => () => source.Increase(1);
        public Func<int, Brightness> Increase => i => new Brightness(source.Value + i);

        public Func<Brightness> DecreaseByOne => () => source.Decrease(1);
        public Func<int, Brightness> Decrease => i => new Brightness(source.Value - i);
    }
}
