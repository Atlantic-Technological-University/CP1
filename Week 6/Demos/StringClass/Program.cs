// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.


// Creating strings

// Declare a string variable but don't assign a reference
System.String nullString = null;

// Initialise a string variable and initialise the contents to ""
string emptyString = string.Empty;

// Initialise a string with a string literal
string newString = "This string contains characters";

string message = "Do penguins reall exist? I have never seen one";
string message2 = new string('?', 40);

Console.WriteLine($"The contents of a null string is: {nullString}");
Console.WriteLine($"The contents of an empty string is: {emptyString}");
Console.WriteLine($"The contents of the newString string is: {newString}");
Console.WriteLine($"The contents of the message string is: {message}");
Console.WriteLine($"The contents of the message string is: {message2}");






// Examples of strings 
Console.WriteLine("\n\nExamples of strings");

string firstName = "Shane"; // assigning a literal string
string lastName = "Wilson";
string phoneNumber = "(555) 983-32432";


// assigning a string by converting a Unicode character
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine(grinningEmoji + " " + firstName + " " + lastName + " " + phoneNumber);


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
