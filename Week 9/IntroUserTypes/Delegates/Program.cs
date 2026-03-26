// Author: Dr. Shane Wilson
// Description: This program demonstrates the use of delegates in C#. Delegates are a powerful feature that allows you
// to pass methods as parameters, create callback methods, and implement event handling. In this example, we will define
// a delegate, create a method that matches the delegate signature, and then invoke the delegate to call the method.

// For a detailed explanation of delegates, see the following article:
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/ 

Console.WriteLine("Welcome to the wonderful world of C# Delegates");

// A delegate is a type that represents references to methods with a particular parameter list and return type.
// When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
// You can invoke the method through the delegate instance. 
// Delegates are used to pass methods as arguments to other methods. Yes, it sounds a bit crazy.

// Jump to line 40 to see the definition of the delegate, then come back here to see how we use it.

// Let's create an instance of the delegate and point it to the Add method defined in the DelegateExamples class
MathOperation operation = Add;

int result = operation(5, 3); // This will call the Add method and return 8
Console.WriteLine($"The result of the operation is: {result}");

// Now switch the method that the delegate points to
operation = Multiply;
Console.WriteLine($"The result of the operation is: {operation(5, 3)}"); // This will call the Multiply method and return 15


// Define some methods that matches the delegate signature for MathOperation below on line 45
int Add(int x, int y)
{
    return x + y;
}

int Multiply(int x, int y)
{
    return x * y;
}

// Start reading here!
// we define a delegate type called MathOperation that takes two integers as parameters and returns an integer.
// This delegate can point to any method that matches this signature, such as the Add and Multiply methods defined above.

// Define a delegate that takes two integers and returns an integer
public delegate int MathOperation(int a, int b);