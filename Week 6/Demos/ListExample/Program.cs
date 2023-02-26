// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

using ListExample;

Console.WriteLine("Example of using list collection");

// Initialise a list
List<Module> modules = new List<Module>();

// Add some modules
modules.Add(new Module("COM101", "C# 101", 82.4f, 1));
modules.Add(new Module("COM102", "C# 201", 60.0f, 1));
modules.Add(new Module("COM111", "Assembly programming", 40.5f, 1));
modules.Add(new Module("COM115", "Mathematics for CS", 100.0f, 1));
modules.Add(new Module("COM201", "Object oriented programming", 72.0f, 2));

Console.WriteLine("Modules taken in year one are");

// Let's process marks
foreach (Module module in modules)
{
    if(module.ModuleYear == 1)
    {
        Console.WriteLine(module);
    }
}
// Example of using IndexOf to find the index of a module in the list
Module searchModule = modules[2];
int index = modules.IndexOf(searchModule);
Console.WriteLine($"The module was found at index: {index}");
