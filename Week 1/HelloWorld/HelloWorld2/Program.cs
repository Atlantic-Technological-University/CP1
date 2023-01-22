namespace HelloWorld2
{
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