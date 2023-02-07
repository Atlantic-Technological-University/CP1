package edu.atudonegal;

import java.io.IOException;
import java.util.Random;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

/**
 * The class Gambler provides a simple implementation of Gambler's ruin. The code starts by asking
 * the player for their starting pot, then their target goal. The game should then simulate the
 * throwing of two dice. If the value of the dice thrown is <6 then the player wins €1, otherwise
 * they loose €1. The game continues until the value of their pot = goal, or they lose all of their
 * money. After each game the player should be asked if they would like to play again. If they do,
 * then they should be asked once again for their starting pot and goal. For more information see:
 * https://en.wikipedia.org/wiki/Gambler%27s_ruin
 */
public class Gambler {

  /**
   * The main entry point of the application.
   *
   * @param args program input arguments - not used.
   */
  public static void main(String[] args) {

    int bets = 0;
    int gameWins = 0;
    int winningThrows = 0;

    String playAgainResponse = "Y";

    Scanner scan = new Scanner(System.in);

    while (playAgainResponse.equals("Y")) {
      int pot = getPot();
      int goal = getGoal();

      // Game logic
      while (pot > 0 && pot < goal) {
        // TO DO - Implement game logic
         bets++;
         if(Math.random() < 0.5)
         { 
            pot++;
         }
         else
         {
            pot--;
         }
         
      }
      if (pot == goal) {
        gameWins++;
        System.out.print(
            "\n\nCongratulations, you beat Gambler's Ruin. Would you like to try your luck again?"
                + " y/n: ");
        pot = 0;

      } else {
        System.out.print("\n\nToo bad, you lost to Gambler's Ruin. "
            + "Would you like to try your luck again? y/n: ");
      }
      String temp = scan.nextLine().toUpperCase();
      playAgainResponse = temp;
    }

    System.out.println("Thank you for playing Gambler's Ruin");
    System.out.println("\n\nYour game statistics are:");
    System.out.println("Number of throws: " + bets);
    System.out.println("Number of winning throws: " + winningThrows);
    System.out.println("Percentage wins : " + 100.0 * winningThrows / bets);
    System.out.println("Winning games : " + gameWins);


  }

  /**
   * Returns an amount of money the player starts with in their pot.
   *
   * @return the amount of money the player starts the game with
   */
  public static int getPot() {

    Scanner scan = new Scanner(System.in);
    System.out.print("How much is your starting bankroll? €: ");
    return scan.nextInt();
  }

  /**
   * Returns an amount of money the player would like to win.
   *
   * @return the amount of money they player would like to win
   */
  public static int getGoal() {
    Scanner scan = new Scanner(System.in);
    System.out.print("How much is your starting bankroll? €: ");
    return scan.nextInt();
  }

  /**
   * Returns the value of two dice being thrown.
   *
   * @return a number in the range [2..12] the result of throwing to dice
   */
  public static int simulateThrow() {

    // TODO
    //Random randomNumber = new Random();
    int randomNum = ThreadLocalRandom.current().nextInt(2, 12 + 1);
    //return randomNumber.nextInt(13);
    return randomNum;
  }
}