// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

// Simple example of pass by value and by reference

// By default arguments are passed by value


string name = "Milo";
Console.WriteLine($"Hello my name is: {name}");
//PassByValue(name);
//Console.WriteLine($"After calling pass by value my name is: {name}");
PassByReference(ref name);
Console.WriteLine($"After calling pass by reference my name is: {name}");

// Even though a string is a reference type a copy is passed by default
void PassByValue(string name)
{
    Console.WriteLine($"Renaming {name} to Aoife");
    Console.Write($"Renaming {name} is now ");
    name = "Aoife";
    Console.WriteLine(name);
}
// Passing a string by reference
void PassByReference(ref string name)
{
    Console.WriteLine($"Renaming {name} to Aoife");
    Console.Write($"Renaming {name} is now ");
    name = "Aoife";
    Console.WriteLine(name);
}


// You can also pass value types by reference
int number = 10;
Console.WriteLine($"The value of the number is {number}");
Console.WriteLine($"Calling PassIntByReference");
PassIntByReference(ref number);
Console.WriteLine($"The value of the number is now {number}");

void PassIntByReference( ref int value)
{
    Console.WriteLine("Incrementing the value");
    value++;
}
