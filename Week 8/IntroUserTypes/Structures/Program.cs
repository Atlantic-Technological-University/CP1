// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

// C# structure demo, structs are declared in the Structs.cs file

using Structures;

Console.WriteLine("Structures demo");

// Create a Coords struct instance
var mousePositon = new Coords(135, 324);
// Write out the position of the mouse
Console.WriteLine("The position of the mouse is: {0}", mousePositon.ToString());

// Copy the struct
Coords copyMousePosition = mousePositon;

// Change the xPos of the mouse
//mousePositon.xPos = 573;
Console.WriteLine("The position of the mouse is: {0}", mousePositon.ToString());
Console.WriteLine("The position of the copy mouse is: {0}", copyMousePosition.ToString());

// Use with expression to make a copy of the copyMousePosition structure
var copyOfCopy = copyMousePosition with { _xPos = 100, _yPos = 200 };
Console.WriteLine("The position of the copy copy is: {0}", copyOfCopy.ToString());


//CoordsReadOnly readOnlyMousePos = new CoordsReadOnly(256, 800);

// Attempt to change the x property of readOnlyMousePos
// readOnlyMousePos.X = 600;  // CS8852 Error - Init-only property or indexer

CoordsReadOnly readOnlyCoords = new CoordsReadOnly(300, 200);

// Use with expression to produce a copy of a structure type instance
CoordsReadOnly copyofreadOnlyCoords = readOnlyCoords with { X = 100, Y = 100 };

// Using the Book struct
Console.WriteLine("\nExample of properties with book struct");

Book currentlyReading = new Book { BookTitle = "SPRQ", ISBN = "978-1846683817" };

currentlyReading.BookTitle = "SPRQ: A history of ancient rome";

Console.WriteLine($"I am currently reading {currentlyReading.BookTitle}");

Console.WriteLine(currentlyReading.BookDetails);

//currentlyReading.ISBN = "newISBN"; // Error CS8852 can't change ISBN 

