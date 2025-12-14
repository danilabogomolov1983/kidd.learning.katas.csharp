using Part1.Domain;
using Part1.Operations;

namespace Test;

public class Instructions
{
    [Fact]
    public void Main_Instructions()
    {
        var grid = Grid.CreateSquare(1000);
        grid.TurnOnRange(new Point(887, 9), new Point(959, 629));
        grid.TurnOnRange(new Point(454,398), new Point(844,448));
        grid.TurnOffRange(new Point(539,243), new Point(559,965));
        grid.TurnOffRange(new Point(370,819), new Point(676,868));
        grid.TurnOffRange(new Point(145,40), new Point(370,997));
        grid.TurnOffRange(new Point(301, 3), new Point(808,453));
        grid.TurnOnRange(new Point(351, 678), new Point(951,908));
        grid.ToggleRange(new Point(720, 196), new Point(897,994));
        grid.ToggleRange(new Point(831, 394), new Point(904,860));

        var count = grid.TurnedOnLights();
        
        Assert.Equal(3, count);

        // turn on 887,9 through 959,629
        // turn on 454,398 through 844,448
        // turn off 539,243 through 559,965
        // turn off 370,819 through 676,868
        // turn off 145,40 through 370,997
        // turn off 301,3 through 808,453
        // turn on 351,678 through 951,908
        // toggle 720,196 through 897,994
        // toggle 831,394 through 904,860
    }
}
