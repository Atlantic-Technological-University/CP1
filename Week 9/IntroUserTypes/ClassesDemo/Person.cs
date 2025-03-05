// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.


namespace ClassesDemo
{
    //[access modifier] - [class] - [identifier]
    public class Person
    {
        public Person()
        {
            //FirstName = "Jane";
            //SecondName = "Doe";
        }
        public Person(string firstname, string secondname)
        {
            FirstName = firstname;
            SecondName = secondname;
        }

        // Finalizer (aka destructor) for the person class
        ~Person()
        {
            // This will automatically get called by the garbage collector.
            // We shouldn't call it.
        }
        public string? FirstName { get; set; } 
        public string SecondName { get; set; }
    }

    public class Adult : Person
    {
        // Readonly static field
        private readonly static int s_minimumAge;

        public Adult(string lastName, string firstName) : base(lastName, firstName)
        { }

        // Static constructor initialises the static field s_minimumAge
        static Adult()
        {
            s_minimumAge = 18;
        }
    }

    // Example Adult class that uses primary constructors format
    // https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors

    /*
    public class Adult(string lastName, string firstName) : Person(lastName, firstName)
    {
        // Readonly static field
        private readonly static int s_minimumAge;

        // Static constructor initialises the static field s_minimumAge
        static Adult()
        {
            s_minimumAge = 18;
        }
    }*/

}
