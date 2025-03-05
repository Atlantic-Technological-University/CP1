// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

Console.WriteLine("Hello, World!");


string alpha = "thequickbrownfoxjumpsoverthelazydog";
string sentence = "The quick brown fox jumps over the lazy dog";
string temp = sentence.Replace(" ", "").ToLower();

foreach(char c in sentence)
{
    alpha=alpha.Replace(c.ToString(),"");
}

Console.WriteLine(temp);

if(alpha.Length > 0)
{
    Console.WriteLine("not a pangram");
}
else Console.WriteLine("pangram");
