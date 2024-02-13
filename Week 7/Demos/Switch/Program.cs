// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.


// Example of a simple switch matching literal values

Console.WriteLine("Greetings professor Falken.");
Console.WriteLine("Shall we play a game?");

Console.WriteLine("List of games");
Console.WriteLine("1.\t Chess");
Console.WriteLine("2.\t Checkers");
Console.WriteLine("3.\t Backgammon");
Console.WriteLine("4.\t Poker");
Console.WriteLine("5.\t Theaterwide Biotoxic and Chemical Warfare");
Console.WriteLine("6.\t Global Thermonuclear War");

Console.Write("\nPlease choose one:");

int option = Convert.ToInt16(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("You have decided to play: Chess");
        break;

    case 2:
        Console.WriteLine("You have decided to play: Checkers");
        break;

    case 3:
        Console.WriteLine("You have decided to play: Backgammon");
        break;

    case 4:
        Console.WriteLine("You have decided to play: Poker");
        break;

    case 5:
        Console.WriteLine("You have decided to play: Theaterwide Biotoxic and Chemical Warfare");
        break;

    case 6:
        Console.WriteLine("You have decided to play: Global Thermonuclear War");
        break;
    
    default:
        Console.WriteLine("You have decided to play: tic-tac-toe");
        break;
}
