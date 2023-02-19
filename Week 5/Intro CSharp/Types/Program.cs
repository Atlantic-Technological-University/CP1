// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.



// A single line comment

/* You can put comments across multiple lines if you wish.
  Use comments to document your code. Well written code is 
  self commenting. If you need to write excessive comments,
  think about refactoring your code! */



// Examples of simple variable declarations
using System.Runtime.Intrinsics.Arm;
/// <summary>
/// 
/// This code example demonstates the C# type system and declaring
/// variables and constants.
/// 
/// </summary>
Console.WriteLine("\n\nExamples of simple variable declarations");

int aSimpleNumber = 232; // Declare a variable called aSimpleNumber and give it the value 232

char c = 'c'; // declare a character
int number1 = c;
int number2 = 'x';
double number3 = 'd';
bool flag = true;

//c = aSimpleNumber; // CS0266 error - Cannot implicitly convert type 'int' to 'char'

// int number4 = aSimpleNumber + flag; // CS0019 error = + cannot be applied to operands of type 'int' and 'bool'

// Print out the value of each variable
Console.WriteLine("The value of aSimpleNumber is {0}", aSimpleNumber);
Console.WriteLine("The value of c is {0}", c);
Console.WriteLine("The value of number1 is {0}", number1);
Console.WriteLine("The value of number2 is {0}", number2);
Console.WriteLine("The value of number3 is {0}", number3);
Console.WriteLine("The value of flag is: {0}", flag);


const double vatRate = 23.0;
// vatRate = vatRate + 1; // CS0131 error - left hand side of assignment must be a variable. You can't change a constant!
Console.WriteLine("The VAT rate in Ireland is: {0}%", vatRate);

// Examples of reference types
Console.WriteLine("\n\nExamples of reference types");

string authorName = "Shane";
object refernceToAuthor = authorName;

Console.WriteLine("The value of autorhName is {0}", authorName);
Console.WriteLine("The value of refernceToAuthor is {0}", refernceToAuthor);


// Examples of implicit type variables

Console.WriteLine("\n\nExamples of var and implicit types");

var guessType1 = "Hello there";
var guessType2 = 234.4;

Console.WriteLine("The variable guessType1 has a value of \"{0}\" " +
    "and a type of {1}", guessType1, guessType1.GetType());
Console.WriteLine("The variable guessType2 has a value of {0} " +
    "and a type of {1}", guessType2, guessType2.GetType());

//guessType = 23; // CS0029 error - Cannot implicitly convert type 'int' to 'string'

