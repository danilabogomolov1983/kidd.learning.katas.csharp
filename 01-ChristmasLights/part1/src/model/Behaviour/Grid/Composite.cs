using model.Types;

namespace model.Behavour;

public delegate Grid GridCreator();
public delegate Grid GridCreatorEx(GridSize gridSize);
static class GridCreatorExtensions
{
    public static GridCreator SetSize(this GridCreatorEx that, GridSize gridSize) => () => that(gridSize);
}
