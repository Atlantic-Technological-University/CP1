// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine("Example of a for each loop");

// Create a list contaning the fibonacci sequence
List<int> fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };


foreach (int element in fibNumbers)
{
    Console.Write($"{element} ");
}
