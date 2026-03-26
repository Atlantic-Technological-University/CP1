// Author: Dr. Shane Wilson
// Description: This program demonstrates how to use delegates with anonymouns methods. If you haven't heard of delegates before,
// check out the Delegates/Program.cs file in this solution to get a good introduction to delegates.
// For a detailed explanation of delegates and anonymous methods, see the following article:
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods
// In this example, we will define a delegate, create an anonymous method that matches the delegate signature,
// and then invoke the delegate to call the anonymous method.

Console.WriteLine("Delegates - as if things couldn't get any stranger\n\n");

// As you saw in the Delegates/Program.cs file, delegates are types that represent references to methods with a particular parameter list and return type.
// In the previous example, we associated a delegate with a names method like Add and Multiply.
// But we can also associate a delegate with an anonymous method, which is a method without a name that is defined inline.


// Jump to line 29 where we define the delegate type, then come back here to see how we use it with an anonymous method.

// Let's create an instance of the WorkCallBack delegate but instead of pointing it at a named method like : MathOperation operation = Add;
// here we  point it to an anonymous method that takes a string parameter and writes it to the console.
// An anonymous method/function doesn't have a name, just an implementation. It is called a Lambda expression in C#. See the LambdaExpressions
// project for more information on Lambda expressions. For now, we will just use an anonymous method to demonstrate how it works with delegates.
WorkCallBack d = (string message) =>
{
    Console.WriteLine($"The message is: {message}");
};

d("Hello, this is an anonymous method!");

// Lets define a delegate that takes a string parameter and returns void. We will call this delegate WorkCallBack.
// Then we will create an instance of this delegate and point it to an anonymous method that takes a string parameter and writes it to the console.
delegate void WorkCallBack(string message);