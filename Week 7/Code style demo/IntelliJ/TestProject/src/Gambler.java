//This code sample is badly formatted and written for a reason!

import java.util.Scanner;  // Import the Scanner class
import java.text.DecimalFormat; // Import text formatting
import java.math.*;


public class Gambler {



    private static int number;


    static int RollDice (int min, int max)
    {
        // Generate a random number between 1 and 12
        int range = (max - min) + 1;

      return (int) (Math.random() * range) + min;
    }


    public static void main (String[] args)
    {

        //int pot = 0;    // gambler's stating bankroll
        int pot;    // gambler's stating bankroll
        int goal = 0;    // gambler's desired bankroll
        int num_games = 1;    // number of games players, the will play at least one game
        int num_bets = 0;     // number of bets places
        int num_wins = 0;     // number of wins
        boolean play_again = true;

        Scanner my_scanner = new Scanner(System.in);  // Create a Scanner object for input


        System.out.println("\n----Welcome to Gambler's Ruin-----\n");

        while (play_again)
        {
            System.out.print("Please enter you starting pot: ");
            pot = my_scanner.nextInt();

            System.out.print("Please enter your  target goal: ");
            goal = my_scanner.nextInt();

            System.out.println("\n\nGame: " + num_games);

          while (pot > 0 && pot < goal)
          {
              num_bets++;
              int roll = RollDice(1, 12);
              System.out.println("\nThrowing the dice....");
              System.out.println("You threw a:  " + roll);

              if (roll < 6)
              {
                  pot++;
                  num_wins++;
                  System.out.println("Congratulations you won 1 and you now have: " + pot + "\n");
              }
              else
              {
                  pot--;
                  System.out.println("Bad luck, you lost a 1 and now have: " + pot + "\n");
              }

          }
          if (pot == goal)
          {
              System.out.print("Well played you reached your goal. Would you like to play again? Y/N: ");
          } else //if (pot == 0)
          {
              System.out.print("Bad luck, you lost all of your pot. Would you like to play again? Y/N: ");
          }

          String temp = my_scanner.next();
          String reply = temp.toUpperCase();

          if (reply.equals("N") || reply.equals("NO"))
          {
              play_again = false;
          }

        }

        System.out.println("\n\nThe total number of bets: " + num_bets);
        System.out.println("The total number of wins : " + num_wins);
        double win_percentage = Double.valueOf(num_wins) / Double.valueOf(num_bets) * 100;
        DecimalFormat df = new DecimalFormat("#.00");
        System.out.println("Win percentage : " + df.format(win_percentage) + "%\n");

        my_scanner.close();
    }
}
