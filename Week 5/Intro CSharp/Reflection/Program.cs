// Written by Dr. Shane Wilson based on CSharp 11 and .NET 6 by Mark Price.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

/// <summary>
/// 
/// This code example uses reflection to get a reference to the the executing application
/// and then loop through each of the assemblies referenced by the application, printing 
/// out a count of the number of types and methods within each referenced assembly.
/// 
/// </summary>

using System.Reflection;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return;

// loop through the assemblies that my app references
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // load the assembly so that we can read its details
    Assembly a = Assembly.Load(name);

    // declare a variable to count the number of methods
    int methodCount = 0;

    // loop through all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the counts of methods
        methodCount += t.GetMethods().Count();
    }

    // output the count of types and their methods
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}
