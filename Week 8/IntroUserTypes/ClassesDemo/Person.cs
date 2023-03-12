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
            FirstName = "Jane";
            SecondName = "Doe";
        }
        public Person(string firstname, string secondname)
        {
            FirstName = firstname;
            SecondName = secondname;
        }
        public string FirstName { get; set; } 
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

}
