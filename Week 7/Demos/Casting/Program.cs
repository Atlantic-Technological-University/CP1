// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

// Simple example of casting between data types


// Implicit converstion is where we convert from one type to another without data loss
// Declare some simple variables

int anIntegerNumber = 15;
Console.WriteLine($"The value of the integer variable anIntegerNumber is {anIntegerNumber}\n");
Console.WriteLine("Declaring a double variable called anDoubleNumber and assigning it the value of anIntegerNumberan\n");
double aDoubleNumber = anIntegerNumber;
Console.WriteLine($"The value of the double variable anIntegerNumber is {aDoubleNumber}");

Console.WriteLine($"The implicit cast from an int to double hasn't led to any loss of data");


// Attempting an unsafe implicit cast will cause result in a compiler error!
// Declare a variable 

int anotherIntegerNumber;
double todaysTemperature = 8.24;

Console.WriteLine($"Today's temperature is {todaysTemperature}");
Console.WriteLine($"Converting today's temperature to an integer value");
anotherIntegerNumber = (int)todaysTemperature; // Need an explicit cast from double to int
Console.WriteLine($"Today's temperature is {anotherIntegerNumber}");

//anotherIntegerNumber = todaysTemperature; // Causes a CS0266 compiler errors


