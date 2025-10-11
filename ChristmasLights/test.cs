#load "grid.cs"
#load "../assert.cs"

using System;
using System.Diagnostics;


Assert(new Grid(10, 10).TurnOn((0, 0), (9, 9)).TurnOff((0, 0), (9, 9)).Calculate() == 0, "test 1 failed");
Assert(new Grid(10, 10).TurnOn((0, 0), (9, 9)).Toggle((0, 0), (9, 9)).Calculate() == 0, "test 2 failed");
Assert(new Grid(10, 10).TurnOn((0, 0), (0, 0)).Calculate() == 1, "test 3 failed");
Assert(new Grid(10, 10).TurnOn((0, 0), (0, 1)).Calculate() == 2, "test 4 failed");

Console.WriteLine("All tests passed!");