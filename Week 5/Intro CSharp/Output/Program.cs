// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine("Hello, World!");

//Console.Write("Hello,");
//Console.Write(" World!");

//Console.WriteLine("This is a string literal");

int numberOfItems = 16;

Console.WriteLine(numberOfItems); // Simple output

// Or convert the numberOfItems to a string and concatenate the strings together
Console.WriteLine("Are you sure that you want to buy " + numberOfItems.ToString() + " oranges?"); 

// Or we could use numbered positional arguments
Console.WriteLine("Yes I need {0} oranges to make fresh orange juice", numberOfItems);

// Or we could use an interpolated string
Console.WriteLine($"Ah, {numberOfItems} oranges seemed like a lot!");

// Print out multiple positional aruments
int numberOfBags = 2;

Console.WriteLine("If you are buying {0} oranges then you will need {1} bags", numberOfItems, numberOfBags);

