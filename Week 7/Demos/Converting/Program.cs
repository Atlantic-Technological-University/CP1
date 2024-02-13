// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

// Simple example of converting between data types

double aSimpleDouble = 12.56;
int aSimpleInt = System.Convert.ToInt32(aSimpleDouble);

Console.WriteLine($"The value of a aSimpleInt is {aSimpleInt}");
// Note the value of 12.56 is rounded up to 13!


// Examples of rounding of doubles when converting to integers in C#
aSimpleInt = System.Convert.ToInt32(10.45);
Console.WriteLine($"The value of a aSimpleInt is {aSimpleInt}");

aSimpleInt = System.Convert.ToInt32(10.5);
Console.WriteLine($"The value of a aSimpleInt is {aSimpleInt}");

aSimpleInt = System.Convert.ToInt32(10.51);
Console.WriteLine($"The value of a aSimpleInt is {aSimpleInt}");

double roundedDouble = Math.Round(12.49, 0, MidpointRounding.ToPositiveInfinity);
Console.WriteLine($"The value of roundedDouble after rounding ToEven is: {roundedDouble}");

// Examples of using ToString() on common base types

Console.WriteLine("\nExamples of converting common base types to string with ToString() method");

int number = 15;
Console.WriteLine(number.ToString());

bool booleanFlag = false;
Console.WriteLine(booleanFlag.ToString());

float pi = (float)Math.PI;
Console.WriteLine(pi.ToString());

DateTime now = DateTime.Now;
Console.WriteLine(now.ToString());

object me = new object();
Console.WriteLine(me.ToString());
