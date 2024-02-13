// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

using System.Diagnostics;

Console.WriteLine("C# examples of arrays");


Console.WriteLine("A simple single dimension array");
float[] firstYearGrades = new float[6];

for (int i = 0; i < firstYearGrades.Length; i++)
{
    Console.Write($"Please enter grade {i + 1}: ");
    firstYearGrades[i] = float.Parse(Console.ReadLine()!);
}

float yearAverage = 0;
for (int i = 0; i < firstYearGrades.Length; i++)
{
    yearAverage = yearAverage + firstYearGrades[i];
}
Console.WriteLine($"The year one year average is " +
    $"{yearAverage / firstYearGrades.Length}");


// Declaring an array and initialising it with values
float[] secondYearGrades = new float[] { 64.5f, 70.4f, 54.8f };

// Use the secondYearGrades array to calculate year average
float secondYearAverage = 0;
foreach (float grade in secondYearGrades)
{
    secondYearAverage = secondYearAverage + grade;
}
Console.WriteLine($"The two one year average is {secondYearAverage / secondYearGrades.Length}");


// An alternative way of initialising an array with values
// no need for the new keyword
float[] thirdYearGrades = { 43.5f, 28.0f, 62.3f };

// Declare a two dimensional array.
int[,] multiDimensionalArray1 = new int[2, 3];

// Declare and set array element values.
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// Declare a jagged array.
int[][] jaggedArray = new int[6][];

// Set the values of the first array in the jagged array structure.
jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

