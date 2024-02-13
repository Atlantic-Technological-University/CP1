// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine("Simple example of a while loop");

int n = 0; // initialise a control variable
while (n < 5) // Boolean condition
{
    // Code block only executes while (n < 5) is true
    Console.Write($"{n} ");
    n++;
}



Console.WriteLine("\nSimple example of a do while loop");
int number = 0;
do
{
    // Code block only executes at least once
    Console.Write($"{number} ");
    number++;

} while (number < 5); // check happens here!

