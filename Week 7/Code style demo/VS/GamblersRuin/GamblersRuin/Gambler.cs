// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;

namespace GamblersRuin
{
    /// <summary>
    /// This example of Gambler's ruin has been written incorrectly to demonstrate code analysis and formatting tools within visual studio. This line is therefore excessively long for a reason!
    /// 
    /// The class Gambler provides a simple implementation of Gambler's ruin. The code starts by asking
    /// the player for their starting pot, then their target goal.The game should then simulate the
    ///throwing of two dice.If the value of the dice thrown is <6 then the player wins €1, otherwise
    /// they loose €1. The game continues until the value of their pot = goal, or they lose all of their
    ///money.After each game the player should be asked if they would like to play again. If they do,
    ///then they should be asked once again for their starting pot and goal.For more information see:
    ///https://en.wikipedia.org/wiki/Gambler%27s_ruin
    /// </summary>
    public static class Gambler {

        private static int bets = 0;
        static private int gameWins = 0;
        private static int winningThrows = 0;
        static private string play_again_response = "Y";

        public static void play_Game() {
            while (play_again_response == "Y") { 
            int pot = getPot();
            int goal = getGoal();
               while (pot > 0 && pot < goal) {
                    //gameplay
                    bets = bets+ 1;
                    int roll = rolldice();
                    Console.WriteLine("\nThrowing the dice....");
                    Console.WriteLine("You threw a:  " + roll);

                    if(roll< 6)                    {
                        pot = pot + 1;
                        winningThrows = winningThrows+ 1;
                        Console.WriteLine($"Congratulations you won 1 and you now have: {pot}");
                    }
                    else {
                        pot = pot - 1;
                        Console.WriteLine($"Bad luck, you lost 1 and you now have: {pot}");
                    }

                }
            if (pot == goal) {
                gameWins++;
                Console.Write(
                    "\n\nCongratulations, you beat Gambler's Ruin. Would you like to try your luck again?"
                        + " y/n: ");
                pot = 0;

            } else
            {
                Console.Write("\n\nToo bad, you lost to Gambler's Ruin. "
                    + "Would you like to try your luck again? y/n: ");
            }
            var response = Console.ReadLine()!.ToUpper();
            play_again_response = response;
        }
            printStats();        }

        static void printStats()
        {
            Console.WriteLine("Thank you for playing Gambler's Ruin");
            Console.WriteLine("\n\nYour game statistics are:");
            Console.WriteLine("Number of throws: " + bets);
            Console.WriteLine("Number of winning throws: " + winningThrows);
            Console.WriteLine("Percentage wins : " + 100.0 * winningThrows / bets);
            Console.WriteLine("Winning games : " + gameWins);
        }
        

     static int getPot() {

            Console.Write("How what is your opening pot:");
            var openingPot = Convert.ToInt16(Console.ReadLine());
            return openingPot;
        }

        static int getGoal() {

            Console.Write("What is your goal amount:");
            var goal = Convert.ToInt16(Console.ReadLine());
            return goal;
        }

        static int rolldice()    {
            Random rand = new Random();
            return rand.Next(2, 12);
        }

    } }


