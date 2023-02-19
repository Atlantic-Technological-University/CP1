// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine("Declare some variables");

int population; // Variable population is declared but not initialised

// CS0165 error - use of unassigned local variable 'population'
//Console.WriteLine($"The value of population is {population}");

population = 3_50_000;
Console.WriteLine($"The value of population is {population}");

double height = 1.78; // Variable population is defined (declared and initialised)

Console.WriteLine($"The value of height is {height}");

const double pi = (float)Math.PI;
//pi = pi+1.2; // CS0131 error - The left-hand side of an assignment must be a variable, property or indexer

Console.WriteLine($"The value of PI is {pi}");
