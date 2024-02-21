// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine("Hello, World!");

Console.Write("Hello,");
Console.Write(" World!");

Console.WriteLine("This is a string literal");
Console.WriteLine("We can join two string literals" + " together.");

int numberOfItems = 16;
// Output a string and then number with two console.write statements
//Console.Write("The number of items is: ");
//Console.WriteLine(numberOfItems);


// Change the console encoding to UTF8
Console.OutputEncoding = System.Text.Encoding.UTF8;
System.Console.Out.WriteLine("€");

decimal accountBalance = 352.64m;
//Write the account balance out by converting to a string and concatenating the string 
//Console.WriteLine("Your account balance is: €" + accountBalance.ToString());
Console.WriteLine("Your account balance is: €" + accountBalance);
Console.WriteLine("Your account balance is: €", accountBalance);



