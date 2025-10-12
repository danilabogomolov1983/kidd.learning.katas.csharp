#load "grid.cs"

using System;
using System.Collections.Generic;
using System.Linq;

var grid = new Grid(1000, 1000);
grid.TurnOn((0, 0), (0, 0));
grid.Toggle((0, 0), (999, 999));
Console.WriteLine($"Lights on: {grid.Calculate()}");
