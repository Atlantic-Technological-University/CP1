// This project illustates named and optional arguments in C#
// For more information read:
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments


// Wrong order of arguments in call results in CS0266 and CS1503 errors
// SimpleFunction(3, "Lion");
SimpleFunction("Lion", 3);

// However we can use named arguments and ignore the specified order in the Function signature
NamedArguments(item: "Zebra", amount: 2);
NamedArguments(amount: 4, item: "Elephant");


// SimpleFunction demonstates a traditional method of 
void SimpleFunction(string item, int amount)
{
    Console.WriteLine($"Are you sure you want to buy {amount} {item}s?");
}

void NamedArguments(string item, int amount)
{
    Console.WriteLine($"Are you sure you want to buy {amount} {item}s?");
}
