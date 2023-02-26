// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.


// Activity solution - keep simulating rolling a pair of dice 
// until the player rolls 12

// Create a random number generator
Random random = new Random(DateTime.Now.Millisecond);
int diceRoll1 = random.Next(1,7); // generate a number between [0 - 6]
int diceRoll2 = random.Next(1,7);
while (diceRoll1 + diceRoll2 != 12) // Boolean condition
{
    // This block will keep executing while the boolean condition is true
    Console.WriteLine($"You threw a {diceRoll1} and a {diceRoll2} unlucky");
    diceRoll1 = random.Next(1,7);
    diceRoll2 = random.Next(1,7);
}
Console.WriteLine($"Congratulations, you threw a 12 with " +
    $"{diceRoll1} and a {diceRoll2}");

// Do while implementation
/*
 int die1 = 0, die2 = 0;

// Keep rolling some dice until the player rolls 12
do
{
    die1 = random.Next(1,7);
    die2 = random.Next(1,7);
    Console.WriteLine($"You threw a {die1} and a {die2} unlucky");
} while (die1 + die2 != 12);
    Console.WriteLine($"Congratulations you threw a {die1} and a {die2} for a 12");
 
 */
