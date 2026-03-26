// Author: Dr. Shane Wilson
// Description: This program demonstrates how to use Lambda expressions in C#. Lambda expressions are a powerful
// feature that allows you to create anonymous functions that can be used as delegates or expression tree types.
// If you haven't heard of delegates before or want to learn more about them, check out the Delegates/Program.cs file
// in this solution to get a good introduction to delegates.
// For more information on Lambda expressions, see:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions


// For a detailed explanation of lambda expressions, see the following article:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions


// We use a Lambda expression to create an anonymous function. To declare a Lambda expression we use the Lambda operator =>,
// which is read as "goes to". The left side of the operator specifies the input parameters and the right side specifies
// the expression or statement block that defines the body of the Lambda expression. Lambda expressions can be used wherever
// a delegate type is expected, such as in LINQ queries or when defining event handlers.


// Lambda expression can take two forms: expression lambdas and statement lambdas.
// Expression lambdas consist of a single expression and return the value of that expression.

// Expression lambdas take the form: (input-parameters) => expression

// Statement lambdas have a statement block and can contain multiple statements. They do not return a value unless you
// explicitly use the return statement.

using LambdaExpressions;

Console.WriteLine("Welcome to Lambda expressions\n\n");

// You can convert a Lambda expression to a delegate type. For example, we can create a Func delegate that takes an int as input
// and returns an int as output, and then assign a Lambda expression to it that calculates the square of a number.
// Traditional anonymous method
// Func<int, int> square = delegate(int x) { return x * x; };

Func<int, int> square = x => x * x;
Console.WriteLine(square(5)); // Output: 25
Console.WriteLine(square(10)); // Output: 100

// If a Lambda expression doesn't return a value you can convert it to an Action delegate type. For example, we can create an
// Action delegate that takes a string as input and returns void, and then assign a Lambda expression to it that prints a greeting message to the console. 

Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
greet("Alice"); // Output: Hello, Alice!

// Create a list of people to demonstrate lambda expressions
List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 30 },
    new Person { Name = "Bob", Age = 25 },
    new Person { Name = "Charlie", Age = 35 }
};

// Now we have a list of people and we want to sort them by age. We could write a separate method that compares the
// ages of two people and then pass that method as a delegate to the Sort method of the list. For example:

// We could sort them like this by passing in an anonymous delegate that compares the ages of two people at a time:
people.Sort(delegate (Person x, Person y)
{
    return x.Age.CompareTo(y.Age);
});


// Alternatively, we can use a lambda expression to achieve the same result in a more concise way:
var sortedByAge = people.OrderBy(p => p.Age);

// The bit we are interested in is the lambda expression p => p.Age, which is a concise way to specify that we want
// to sort the people by their Age property. It basically says "for each person p, use their Age property as the key for sorting".
// This is much more concise than writing a separate method or using an anonymous delegate.
