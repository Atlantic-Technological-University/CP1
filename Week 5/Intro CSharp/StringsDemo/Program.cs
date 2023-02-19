// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.


// Examples of strings 
Console.WriteLine("\n\nExamples of strings");

string firstName = "Shane"; // assigning a literal string
string lastName = "Wilson";
string phoneNumber = "(555) 983-32432";


// assigning a string by converting a Unicode character
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine(grinningEmoji, firstName, lastName, phoneNumber);

// Verbatim string - we can include escape seqeuences
string verbatimString = "\nShane\tWilson";
Console.WriteLine(verbatimString);

// CS1009 error Unrecognised escape sequence
// string filePath = "C:\trusted sources\datafiles\data.txt"; 

// use the '@' to declare a verbatim string
string filePath = @"C:\trusted sources\datafiles\data.txt";
Console.WriteLine(filePath);
Console.WriteLine();

// raw string literals
string rawString = """
                <person age "40">
                    <first_name>Peter</first_name>
                </person>
                """;

Console.WriteLine(rawString);


// String interpolation
Console.WriteLine("\nUsing string interpolation");

var date = DateTime.Now;

// We could use string composite formatting to output the date time
Console.WriteLine(String.Format("The time is now {0:hh:mm}", date));

// Or we could use string interpolation
Console.WriteLine($"The current time is {date:HH:mm}");




// String / object reference type comparison
Console.WriteLine("\nReference type comparison");

string s1 = "hello!";
object obj1 = s1;
object obj2 = s1;
object obj3 = "hello";

Console.WriteLine(s1 == obj1); // output: true
Console.WriteLine(obj1 == obj2); // output: true
Console.WriteLine(s1 == obj2); // output: true
Console.WriteLine(s1 == obj3); // output: false

