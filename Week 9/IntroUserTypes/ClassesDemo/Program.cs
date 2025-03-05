﻿// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

using ClassesDemo;

Console.WriteLine("C# Classes and objects");

// Create an instance of the Person class
Person mise = new Person();

// Object type is explicit so we can use var
var newPeron = new Person();

// Much more concise than earlier examples
Person anotherPerson = new();

// Using object initializers to simplify object creation
var yetAnotherPerson = new Person {FirstName = "Toby", SecondName = "Weisner" };

string test = yetAnotherPerson.FirstName;
Console.WriteLine(test);

Console.WriteLine("Create an adult");
Adult parent = new Adult("parent", "parent");

Adult anotherAdult = new Adult("parent2", "parent2");

Console.WriteLine(anotherAdult.ToString());

// Checking for null values

// Create a person with a null FirstName
var nullPerson = new Person();

// if(nullPerson.FirstName != null)
// if(nullPerson.FirstName is not null)
if(nullPerson is not null)
{
    string firstName = nullPerson.FirstName ?? "John Doe";
    Console.WriteLine($"The new person is called {firstName}");
}
else
{
    Console.WriteLine($"I don't know what the new person is called!");
}

//int? length = nullPerson.FirstName?.Length ?? 3;
//Console.WriteLine($"The new person is called {nullPerson.FirstName}");
