namespace HelloWorld2
{
    // This is an example of a C# program that does not use top level statements and instead uses
    // or rather exposes a traditional Main method to the developer.
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current directory: ");

            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine($".NET runtime version: {Environment.Version.ToString()}");
            Console.WriteLine("Operating system: {0}", Environment.OSVersion.VersionString);
        }
    }
}