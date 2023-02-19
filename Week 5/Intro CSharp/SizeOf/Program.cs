// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

Console.WriteLine($"Byte uses {sizeof(byte)} bytes and can sore numbers in the range of {byte.MinValue} to {byte.MaxValue:N0}");
Console.WriteLine($"Short uses {sizeof(short)} bytes and can sore numbers in the range of {short.MinValue} to {short.MaxValue:N0}");

Console.WriteLine($"Int uses {sizeof(int)} bytes and can sore numbers in the range of {int.MinValue} to {int.MaxValue:N0}");
Console.WriteLine($"UInt uses {sizeof(uint)} bytes and can sore numbers in the range of {uint.MinValue} to {uint.MaxValue:N0}");
Console.WriteLine($"Long uses {sizeof(long)} bytes and can sore numbers in the range of {long.MinValue} to {long.MaxValue:N0}");

Console.WriteLine($"Float uses {sizeof(float)} bytes and can sore numbers in the range of {float.MinValue} to {float.MaxValue:N0}");
Console.WriteLine($"Double uses {sizeof(double)} bytes and can sore numbers in the range of {double.MinValue} to {double.MaxValue:N0}");
Console.WriteLine($"Decimal uses {sizeof(decimal)} bytes and can sore numbers in the range of {decimal.MinValue} to {decimal.MaxValue:N0}");

// What about strings? // CS0233 error - string does not have a predefined size
// Console.WriteLine($"String uses {sizeof(string)} bytes and can sore numbers in the range of {string.MinValue} to {string.MaxValue:N0}");


