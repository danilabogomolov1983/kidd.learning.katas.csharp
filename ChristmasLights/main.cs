#load "grid.cs"

using System;
using System.Collections.Generic;
using System.Linq;

var grid = new Grid(1000, 1000);
grid.TurnOn((887, 9), (959, 629));
grid.TurnOn((454, 398), (844, 448));
grid.TurnOff((539, 243), (559, 965));
grid.TurnOff((370, 819), (676, 868));
grid.TurnOff((145, 40), (370, 997));
grid.TurnOff((301, 3), (808, 453));
grid.TurnOn((351, 678), (951, 908));
grid.Toggle((720, 196), (897, 994));
grid.Toggle((831, 394), (904, 860));
Console.WriteLine($"Lights on: {grid.Calculate()}");