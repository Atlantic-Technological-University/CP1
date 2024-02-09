// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

// Simple example of using try catch

int Area(int length, int width)
{
    if (length <= 0 || width <= 0)
    {
        throw new ArgumentException("Arguments cannot be zero");
    }
    return length * width;

}

//try
//{
//    Console.Write("Please enter a value for lenght ");
//    int length = int.Parse(Console.ReadLine()!);
//    // It is possible for input to be null, so we add '!' the null forgiving operator to disable
//    // the compiler warning. We should really check for null types in production ready code. 
//    Console.Write("Please enter a value for width ");
//    int width = int.Parse(Console.ReadLine()!);

//    Console.WriteLine($"The area is {Area(length, width)}");

//}
//catch (ArgumentException e)
//{
//    Console.WriteLine($"An exception of type {e} occured");
//}


// Slightly better version with input validation
try
{
    bool validLength = false, validWidth = false;
    int length=1, width=1;
    string? user_input;
    while (!validLength)
    {
        Console.Write("Please enter a value for lenght ");
        user_input = Console.ReadLine();
        if (int.TryParse(user_input, out length))
        {
            validLength = true;
        }
        else
        {
            Console.WriteLine("Please enter a valid length");
        }
    }
    while (!validWidth)
    {
        Console.Write("Please enter a value for width ");
        user_input = Console.ReadLine();
        if (int.TryParse(user_input, out width))
        {
            validWidth = true;
        }
        else
        {
            Console.WriteLine("Please enter a valid width");
        }
    }
    
    Console.WriteLine($"The area is {Area(length, width)}");
}
catch (ArgumentException e)
{
    Console.WriteLine($"An exception of type {e} occured");
}






//Generic format of try / catch.
try
{
    // Call error prone code
    throw new Exception("Oh Ooooo!");
    // Really, we should not throw generic exceptions! see:
    // https://rules.sonarsource.com/csharp/RSPEC-112/
}
catch (Exception e)
{
    // Deal with the exception
    Console.WriteLine($"An exception has occured: {e}");
}
finally
{
    // executed regardless of whether an exception is raised
    // Use a finally block to release resources, eg file streams
}


