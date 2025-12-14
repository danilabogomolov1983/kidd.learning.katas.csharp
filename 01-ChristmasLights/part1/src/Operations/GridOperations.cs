using System.Linq.Expressions;

using Part1.Domain;

namespace Part1.Operations;

public static class GridOperations
{
    extension(Grid source)
    {
        public Action<Point> TurnOn => p =>
        {
            source.Update(p, Light.On);
        };

        public Action<Point> TurnOff => p =>
        {
            source.Update(p, Light.Off);
        };
        
        public Action<Point> Toggle => p =>
        {
            var light = source.Get(p);
            source.Update(p, light == Light.On ? Light.Off : Light.On);
        };

        public  Func<int> TurnedOnLights => () => source.CountByStateFunction(i => i == Light.On);
        public  Func<int> TurnedOffLights => () => source.CountByStateFunction(i => i != Light.On);
        private Func<Expression<Func<Light?, bool>>, int> CountByStateFunction => predicate =>
        {
            var tmp = source.LightsAsQueryable();
            var tmp2 = tmp.Count(predicate);

            return tmp2;
        };
        public Action<Point, Point> TurnOnRange => (from, to) => source.RangeAction(from, to, source.TurnOn);
        public Action<Point, Point> TurnOffRange => (from, to) => source.RangeAction(from, to, source.TurnOff);
        public Action<Point, Point> ToggleRange => (from, to) => source.RangeAction(from, to, source.Toggle);

        private Action<Point, Point, Action<Point>> RangeAction => (from, to, action) =>
        {
            for (var x = from.X; x <= to.X; x++)
            {
                for (var y = from.Y; y <= to.Y; y++)
                {
                    action(new Point(x, y));
                }
            }
        };
    }
}
