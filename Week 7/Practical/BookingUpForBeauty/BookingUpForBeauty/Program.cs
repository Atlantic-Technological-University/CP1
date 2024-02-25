// See https://aka.ms/new-console-template for more information
using BookingUpForBeauty;
//using System.Globalization;

Console.WriteLine("Hello, World!");

// Set the culutre info for dates to Irish
var enIeCulture = new CultureInfo("en-IE");
Thread.CurrentThread.CurrentCulture = enIeCulture;
Thread.CurrentThread.CurrentUICulture = enIeCulture;

// Add any prototyping code here
// Remember to check out the documentation for the DateTime strut online:
// https://learn.microsoft.com/en-us/dotnet/api/system.datetime

// When constructing strings from multiple elements you should use the StringBuilder class
// https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder