#load "grid.cs"
#load "../../assert.cs"

using System;
using System.Diagnostics;


Assert(new Grid(10, 10).TurnOn((0, 0), (0, 0)).Calculate() == 1, "test 1 failed");
Assert(new Grid(1000, 1000).Toggle((0, 0), (999, 999)).Calculate() == 2000000, "test 2 failed");

Console.WriteLine("All tests passed!");
