// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine("\nDeclaring and initialising Integral numeric types ");
// unsigned interger are used for positive whole number or 0
uint customerAge = 32;

Console.WriteLine("Initialising an unsigned integer : uint customerAge = 32");
Console.WriteLine($"The value of customerAge :{customerAge}");

// signed interger are used for positive or negative whole numbers or 0
int gameScore = -4;

Console.WriteLine("Initialising a signed integer : int gameScore = -4");
Console.WriteLine($"The value of gameScore :{gameScore}");

// using the digit separator to improve readability
int aMillion = 1_000_000;
Console.WriteLine("Initialising a signed integer with digit separator : int aMillion = 1_000_000;");
Console.WriteLine($"The value of aMillion  :{aMillion:N0}");


Console.WriteLine("\nDeclaring Integrals with hexadecimal and binary");
int hexLiteral = 0x2A; // use the prefix 0x or 0x for hexadecimal
int binaryLiteral = 0b_10010_1010; // use the prefix 0b or 0B for binary

Console.WriteLine("Initialising a integer with hex: int hexLiteral = 0x2A");
Console.WriteLine($"The value of hexLiteral :{hexLiteral}");
Console.WriteLine("Initialising a signed integer : int binaryLiteral = 0b_10010_1010");
Console.WriteLine($"The value of binaryLiteral :{binaryLiteral}");



Console.WriteLine("\n\nDeclaring and initialising real numbers");

// floats are used for real numbers. Require 4 bytes 
float floatNumber = -455.1454f; // Note we use 'f' to declare a float

Console.WriteLine("Initialising a float : float floatNumber = -455.14544;");
Console.WriteLine($"The value of floatNumber :{floatNumber}");

// double are used for real numbers. Require 8 bytes 
double temperature = 25.4;

Console.WriteLine("Initialising a double : double temperature = 25.4;");
Console.WriteLine($"The value of temperature:{temperature}");

// double are used for real numbers. Require 16 bytes 
decimal ecbInterestRate = 3.0m; // note we use 'm' to declare a decimal

Console.WriteLine("Initialising a double : decimal ecbInterestRate = 3.0;");
Console.WriteLine($"The value of ecbInterestRate:{ecbInterestRate}");
