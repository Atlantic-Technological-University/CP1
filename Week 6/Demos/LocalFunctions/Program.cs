// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.


Console.WriteLine("Local functions");

// Declaring our function
//void DoSomething() //Function is called DoSomething
//{
//    // Function body
//    Console.WriteLine("Calling do something");
//}
//Calling our function
DoSomething();


// Passing data to a function
//void DisplayaMessage(string message) //Function is called DoSomething
//{
//    // Function body
//    //Console.WriteLine("Calling do something");
//    Console.WriteLine($"The function DoSomething was passed the value: \"{message}\"");
//}

// Calling our function
DisplayMessage("hello there!");

Console.WriteLine("Adding two numbers");
int numb1 = 3, numb2 = 4;
int sum = AddTwoNumbers(numb1, numb2);
//int sum = AddTwoNumbers(number1: 3, number2: 5);
Console.WriteLine($"The sum of adding {numb1} and {numb2} is: {sum}");
