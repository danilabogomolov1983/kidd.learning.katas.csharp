using Modules.Common.Model;
using Modules.Grid.Model;

namespace Modules.Grid;

public delegate GridInfo SetWidth(int value);
public delegate GridInfo SetHeight(int value);

public delegate GridInfo CreateGrid();
public delegate GridInfo CreateGridEx(WidthValue widthValue, HeightValue heightValue);

internal static class CreateGridExExtensions
{
    public static CreateGrid SetWidth(this CreateGridEx that, WidthValue widthValue) => () => that(widthValue);
}
