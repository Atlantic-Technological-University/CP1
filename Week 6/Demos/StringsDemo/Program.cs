// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.


// Examples of strings 
Console.WriteLine("\nCommon string operations");

//// String concatenation

//string part1 = "Hello";
//string part2 = " World";
//Console.WriteLine(part1.ToLower() + part2.ToUpper());

////string part3 = string.Concat(part1, part2); // we could also do this
////Console.WriteLine($"The concatenated string is \"{part3}\"");
////Console.WriteLine($"The concatenated string is \"{string.Concat(part1, part2)}\"");

//// Formatting text as upper case and lower case - note the methods return copies of the original strings
//Console.WriteLine(part1.ToLower() + part2.ToUpper());

//// Note the original strings are unchanged
//Console.WriteLine("Original string varaibles: " + part1 + part2);

// Substring and string length examples
string message = "Quis custodiet ipsos custodes?";

// Get the length of the string message
Console.WriteLine($"The message is \"{message}\"");
Console.WriteLine($"The message {message} is {message.Length} characters long");

// Get the substring from 4 to the end
string subString1 = message.Substring(4);
Console.WriteLine(subString1);
// Get the substring starting at index 4 to the 10
string subString2 = message.Substring(4, 10);
Console.WriteLine(subString2);


// Get the index of ipsos
int index = message.IndexOf("ipsos");
Console.WriteLine($"The first occurance of the word \"ipsos\" is at index {index}");

// Example of replace
// Replace every sub-string "Quis" with "Who"
string newMessage = message.Replace("Quis", "Who");
Console.WriteLine(newMessage);
// Replace every 's' with a '$'
newMessage = message.Replace('s', '$');
Console.WriteLine(newMessage);

// Example of splitting a string
// Split the string using space ' ' as a delimiting character
string[] subStrings = message.Split(' ');
// Using a foreach loop to print out each sub string in the array
foreach (string substring in subStrings)
{
    Console.WriteLine(substring);
}



//string firstName = "Shane"; // assigning a literal string
//string lastName = "Wilson";
//string phoneNumber = "(555) 983-32432";


//// assigning a string by converting a Unicode character
//string grinningEmoji = char.ConvertFromUtf32(0x1F600);
//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine(grinningEmoji + " " + firstName + " " + lastName + " " + phoneNumber);

