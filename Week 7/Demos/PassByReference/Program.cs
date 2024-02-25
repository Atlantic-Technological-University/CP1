// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


Console.WriteLine("Demos of pass by value and reference");


// Demo of pass by value

//string name = "Milo";
//Console.WriteLine($"Hello my name is: {name}");
////PassByValue(name);
////Console.WriteLine($"After calling pass by value the value of name is: {name}");

//PassByReference(ref name);
////Console.WriteLine($"After calling pass by reference the value of name is: {name}");
//void PassByValue(string name)
//{
//    Console.WriteLine($"Renaming {name} to Aoife");
//    Console.Write($"{name} is now ");
//    name = "Aoife";
//    Console.WriteLine(name);
//}

//void PassByReference(ref string name)
//{
//    Console.WriteLine($"Renaming {name} to Aoife");
//    Console.Write($"{name} is now ");
//    name = "Aoife";
//    Console.WriteLine(name);
//}


int number = 10;
Console.WriteLine(number);
PassIntByReference(ref number);
Console.WriteLine(number);

void PassIntByReference(ref int number)
{
    number++;
}
