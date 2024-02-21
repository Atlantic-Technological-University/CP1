// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.Write("Hello how are you today? ");
string response = Console.ReadLine();

Console.WriteLine($"Great to hear that you are feeling {response} today");

// we can append the null-forgiving operator to tell the compiler 
// that the ReadLine won't return a null
//string response = Console.ReadLine()!;
Console.WriteLine($"Great to hear that you are feeling {response} today");

Console.Write("How old are you? ");
string age = Console.ReadLine();

Console.WriteLine("So you are " + age + " years old");

// We should really convert the string input to a number. We will cover converting between
// C# types later in the course. 
