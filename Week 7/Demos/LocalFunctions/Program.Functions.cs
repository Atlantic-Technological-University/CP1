// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

/// <summary>
/// A class defined as "partial" allows the class defintion to be spread across several files. This
/// is useful when we want to separate a class defintion. This makes sense when we are using top 
/// level statements with C#.
/// </summary>
partial class Program
{
    // Passing data to a function
    static void DisplayMessage(string message) 
    {
        // Function body
        //Console.WriteLine("Calling do something");
        Console.WriteLine($"The function DoSomething was passed the value: \"{message}\"");
    }
    // Declaring our function
    static void DoSomething() //Function is called DoSomething
    {
        // Function body
        Console.WriteLine("Calling do something");
    }

    static int AddTwoNumbers(int number1, int number2)
    {
        return number1+ number2;
    }

}
