using Modules.Common.Model;

namespace Modules.Common;

public static class CommonExtensions
{
    public static int AsInt(this Side that) => that.Value;
}
