#load "grid.cs"
#load "../../assert.cs"

using System;
using System.Diagnostics;


Assert(new Grid(10, 10).TurnSquareOn(Position.Create(0, 0), Position.Create(9, 9)).TurnSquareOff(Position.Create(0, 0), Position.Create(9, 9)).Calculate() == 0, "test 1 failed");
Assert(new Grid(10, 10).TurnSquareOn(Position.Create(0, 0), Position.Create(9, 9)).ToggleSquare(Position.Create(0, 0), Position.Create(9, 9)).Calculate() == 0, "test 2 failed");
Assert(new Grid(10, 10).TurnSquareOn(Position.Create(0, 0), Position.Create(0, 0)).Calculate() == 1, "test 3 failed");
Assert(new Grid(10, 10).TurnSquareOn(Position.Create(0, 0), Position.Create(0, 1)).Calculate() == 2, "test 4 failed");

Console.WriteLine("All tests passed!");
