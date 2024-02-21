// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

Console.WriteLine("String equality demos");

// Lets create two strings objects using the new keyword

string string1 = new string("Hello world");
string string2 = new string("Hello world");


// Assign the object string3 reference to refer to string2
object objString3 = string2;

// Use == to check if the values are equal
bool areEqual = string1 == string2;

Console.WriteLine($"String1 == string2: {areEqual}");
// Using the Equals method
Console.WriteLine($"string1.Equals(string2): {string1.Equals(string2)}");

// Check reference equality with ReferenceEquals
Console.WriteLine($"string1 and string2 refer to the same reference: {ReferenceEquals(string1, string2)}");
Console.WriteLine($"string1 and objString3 refer to the same reference: {ReferenceEquals(string1, objString3)}");
Console.WriteLine($"string2 and objString3 refer to the same reference: {ReferenceEquals(string2, objString3)}");

// The C# compiler will optimise variable declarations using an intern pool
// see: https://dailydotnettips.com/the-string-intern-pool/

// Declare and initialise two new strings
// Two string variables are declared on the stack but both refer to the same string literal on the heap 
string string4 = "C# optimises sting variables"; 
string string5 = "C# optimises sting variables"; 
Console.WriteLine($"String4 == string5: {ReferenceEquals(string4, string5)}");

// Find out if the string is in the intern pool
string internedString = string.Intern( string1 );
if (internedString == null)
    Console.WriteLine("'{0}', is not interned.", string1);
else
    Console.WriteLine("'{0}', is interned.", string1);



