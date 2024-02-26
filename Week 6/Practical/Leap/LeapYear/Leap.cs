/* 
 * Filename: Leap.cs
 * Description: A skeleton class for a C# practical exercise covering selection statements in C#
 * 
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/practice/leap
 */

/*
* Instructions:
* Implement the method below that checks if a date is a leap year. 
* A leap year (in the Gregorian calendar) occurs:
* In every year that is evenly divisible by 4.
* Unless the year is evenly divisible by 100, in which case it's only a leap year if the year 
* is also evenly divisible by 400.
* 
* Some examples:
*
*   1997 was not a leap year as it's not divisible by 4.
*   1900 was not a leap year as it's not divisible by 400.
*   2000 was a leap year!
* 
*/

using System;

namespace LeapYear
{
    public static class Leap
    {
        /// <summary>
        /// The <c>IsLeapYear</c> method takes an int year and returns true if it is a leap year,
        /// otherwise false.
        /// </summary>
        /// <param name="year"></param> represents the <c>int</c>"/> year to check.
        /// <returns><c>bool</c></returns> true if the year is a leap year otherwise false.
        /// <exception cref="NotImplementedException"></exception>
        public static bool IsLeapYear(int year)
        {
            //TODO Implement the IsLeapYear method
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
