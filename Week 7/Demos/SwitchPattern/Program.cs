// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

// Example of a C# switch using pattern and relational matching

using System.Diagnostics.Metrics;

Console.WriteLine("Example of a C# switch using pattern matching");

Console.Write("\nPlease enter a sensor reading value: ");
string? input = Console.ReadLine()!;
double measurement;
if (input.Length>0)
{
    measurement = Convert.ToDouble(input);
}
else
    { measurement = double.NaN; }

switch (measurement)
{
    case < 0.0: // checks if measurement is 
        Console.WriteLine($"Measured value is {measurement}; too low.");
        break;

    case > 15.0:
        Console.WriteLine($"Measured value is {measurement}; too high.");
        break;

    // checks measurement against a constant NaN which specifies a the value is not a number
    case double.NaN: 
        Console.WriteLine("Failed measurement.");
        break;

    default:
        Console.WriteLine($"Measured value is {measurement}.");
        break;
}

// An example of a switch with case guards
int a, b;
a=3; b=4;

switch ((a, b))
{
    case ( > 0, > 0) when a == b: //case guard
        Console.WriteLine($"Both measurements are valid and equal to {a}.");
        break;

    case ( > 0, > 0):
        Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
        break;

    default:
        Console.WriteLine("One or both measurements are not valid.");
        break;
}


