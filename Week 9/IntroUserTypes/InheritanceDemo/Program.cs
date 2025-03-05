// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

using InheritanceDemo;

Console.WriteLine("Classes example in C#");

// Let's create some animals
// Demonstrate differnt forms of object instantiation
//var unknownAnimal = new Animal();
//unknownAnimal.Name = "Mothman";

Reptile knownReptile = new();
knownReptile.Name = "Mongolian death worm";

Mammal unknownMammal = new()
{
    Name = "Sasquatch"
};

Mammal cryptid = new Mammal("Chupacabra");

// As the Mammal class provides a version of the Virtual method Speak, when it is called on 
// an instance of Mammal, the Mammal class's version of Speak is called. 
Console.WriteLine(unknownMammal.Speak());

// The Reptile class doesn't provide an implementation that overrides the Animal Speak method.
// So when Speak is called on an instance of Reptile, the base implementation version of the 
// Speak method is called. 
Console.WriteLine(knownReptile.Speak());


