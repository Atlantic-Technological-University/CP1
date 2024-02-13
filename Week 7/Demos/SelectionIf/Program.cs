// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine("Example of selection statements in C#");

Console.WriteLine("\nSimple if statement");

// Define a float that stores the temperature
float temperatureToday = 12.3f;
// Example of simple if statement
// If block statement executes of the boolean condition (temperatureToday < 15.0) equates to true
if(temperatureToday < 15.0)
{
    Console.WriteLine("It is a little chilly today, bring a jacket");
}

Boolean rainForecast = true;

//if ((temperatureToday < 15.0) && (rainForecast)) // could also be typed like this
if (temperatureToday < 15.0 && rainForecast)
{
    Console.WriteLine("It is a little chilly today, bring a jacket and an umbrella");
}

// Example of Nesting the if statement
rainForecast= false; // change to false then true and track through the debugger
if (temperatureToday < 15.0)
{
    Console.Write("It is a little chilly today, bring a jacket");
    if (rainForecast)
    {
        Console.Write(" and an umbrella");
    }
}

// Example of if with else
bool isCloudy = true;
if (isCloudy)
{
    Console.WriteLine("You may want to bring an umbrella or raincoat with you");
}
else
{
    Console.WriteLine("Enjoy the sunshine");
}

// We could also write our previous if / else without the curly braches
// Curly braces improve readabity and reduce errors
// Rule - include curly braces
//bool isCloudy = true;
//if (isCloudy)
//    Console.WriteLine("You may want to bring an umbrella or raincoat with your");
//else
//    Console.WriteLine("Enjoy the sunshine");

// Example of if with else if

temperatureToday= 23.4f;
rainForecast= true;

if (temperatureToday < 15)
{
    Console.WriteLine("It is a little chilly today, bring a jacket");
}
// we could use && or & but && give better performance as if any condition is false
// the entire expression returns false without checking the others
else if (temperatureToday > 15 && temperatureToday < 18)
{
    Console.Write("The temperature is going to be between 15'c and 18'c");
    if (rainForecast)
    {
        Console.WriteLine(", but rain is forecast bring an umbrella ");
    }
    else
    {
        Console.WriteLine(", and rain isn't forecast so no need for an umbrella");
    }
}
else if (temperatureToday > 23 && rainForecast !=true)
{
    Console.WriteLine("It is going to be a great day, time to head to the shore?");
}
else
{

}
