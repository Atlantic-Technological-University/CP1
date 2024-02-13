// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

// Example of using switch expressions

// Creating a simple object of type developer

using SwitchExpression;

object obj = new Developer();

string favoriteTask = obj switch
{
    Developer => favoriteTask = "Writing code",
    Manager => favoriteTask = "Creating more work for employees",
    _ => "Staring out the window", // default option
};

Console.WriteLine(favoriteTask);
