// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

// Simple example of converting from string to numbers using Parse



using System.ComponentModel.Design;
using System.Globalization;

int age = int.Parse("23");
Console.WriteLine(age);

DateTime importantDate1 = DateTime.Parse("12/6/1945");
// Is 12/6/45 12th of June or 6th of December?
// To avoid incorrectly parsed dates, specify additional culture info

DateTime importantDate2 = DateTime.Parse("12/6/1945", new CultureInfo("en-US", false));

Console.WriteLine(importantDate1);
Console.WriteLine(importantDate2);

//DateTime importantDate2 = DateTime.Parse("12/6/1945", new CultureInfo("en-US", false));

/* For additional information see:
 * https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo
 * https://phrase.com/blog/posts/all-you-need-to-know-about-cultureinfo-in-net-applications/
 */

// We will encounter an error when we attempt to parse incorrect data
// int number = int.Parse("c#"); // Results in a System.FormatException

Console.WriteLine("\nShall we play a game?\n");
Console.WriteLine("1. Falken's Maze\n2. Black Jack\n3. Gin Rummy\n4. Hearts\n5. Bridge");
Console.WriteLine("6. Checkers\n7. Chess\n8. Poker\n10. Fighter Combat\n11. Guerrilla Engagement");
Console.WriteLine("12. Desert Warfare\n13. Air-To-Ground Actions\n14. Theaterwide Tactical Warefare");
Console.WriteLine("15. Theaterwide Biotoxi and Chemical Warefare\n16. Global Thermonuclear War");
Console.Write("\nPlease select which game you would like to play:");

string? selection = Console.ReadLine();
if (int.TryParse(selection, out int selectedGame))
{
    Console.WriteLine($"You have selected to play game {selectedGame}");
}
else
{
    Console.WriteLine("I could not understand your selection");
}



