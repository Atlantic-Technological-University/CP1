// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

namespace InheritanceDemo
{
    /// <summary>
    /// A simple C# class that demonstrates inheritance.
    /// </summary>
    public abstract class Animal
    {
        public Animal()
        {
            Name = "Unknown animal";
            Console.WriteLine($"Creating an instance of {GetType()}");
        }
        /// <summary>
        /// Non-default (overloaded) constructor for the Animal class initialises the object.
        /// </summary>
        /// <param name="name">the name of the animal</param>
        public Animal(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        /// <summary>
        /// A silly method to illustrate virtual methods. Methods marked as virual can be 
        /// overriden by any class that is derived from this class. 
        /// </summary>
        /// <returns>a string</returns>
        public virtual string Speak() 
        {
            return "Animal is speaking";
        }

        /// <summary>
        /// A silly method to illustrate abstract methods. Abstract methods must be implemented
        /// by the derived class
        /// </summary>
        /// <returns>a string describing how the animal moves.</returns>
        public abstract string Move();
    }

    public class Mammal : Animal
    {
        public Mammal()
        {
            Console.WriteLine($"Creating an instance of {GetType()}");
        }

        /// <summary>
        /// The Mammal non-default constructor uses the :base keyword to call the constructor of
        /// the base class Animal, passing the name of the animal.
        /// </summary>
        /// <param name="name">the name of the animal.</param>
        public Mammal(string name) : base(name) { }

        public override string Speak()
        {
            return "Mammal is speaking";
        }
        public override string Move()
        {
            return "Mammal is moving";
        }
    }

    public class Reptile : Animal
    {
        public Reptile()
        {
            Console.WriteLine($"Creating an instance of {GetType()}");
        }

        public override string Move()
        {
            return "Reptile is moving";
        }
    }
}
