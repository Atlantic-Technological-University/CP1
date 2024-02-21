// Licensed to the .NET Founda// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine("Composite formatting");


// Composite formatting
string message = string.Format("Name = {0}, hours = {1:HH:mm}", "Fred", DateTime.Now);
Console.WriteLine(message);

// Change the console encoding to UTF8
Console.OutputEncoding = System.Text.Encoding.UTF8;
System.Console.Out.WriteLine("€");

decimal accountBalance = 352.64m;

//Using string composite formatting
Console.WriteLine("Your account balance is: {0}", accountBalance);

// Using string interpolation
Console.WriteLine($"Your account balance is: {accountBalance}");

int numberOfItems = 15;

// Or convert the numberOfItems to a string and concatenate the strings together
Console.WriteLine("Are you sure that you want to buy " + numberOfItems.ToString() + " oranges?");

// Or we could use numbered positional arguments
Console.WriteLine("Yes I need {0:C3} oranges to make fresh orange juice", numberOfItems);

// Or we could use an interpolated string
Console.WriteLine($"Ah, {numberOfItems} oranges seemed like a lot!");

// Print out multiple positional aruments
int numberOfBags = 2;

Console.WriteLine("If you are buying {0} oranges then you will need {1} bags", numberOfItems, numberOfBags);


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
