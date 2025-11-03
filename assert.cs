using System;


void Assert(bool condition, string message)
{
    if (!condition) throw new Exception(message);
}
