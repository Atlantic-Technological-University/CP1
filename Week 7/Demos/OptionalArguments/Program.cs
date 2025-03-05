// This example demonstates the use of optional arguments in method calls.
// See: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments#optional-arguments


// Call PurchasePet method but don't supply an argumentfor discount
PurchasePet("Turtle", 3);

// Call PurchasePet method and supply an argument for discount
PurchasePet("White Shark", 4, 25.0f);

void PurchasePet(string item, int amount, float discount = 0.0f)
{
    // Optional parameters are defined after required parameters
    // Optional parameters have default values
    Console.WriteLine($"Are you sure you want to buy {amount} {item}s?");
    Console.WriteLine($"Your discount on this purchase will be {discount:F2}%");
}
