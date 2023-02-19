// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

namespace HelloWorld
{ // an open brace indicates the start of a block
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");

            //Console.WriteLine("Hello, World!"); // a statement

            string s1 = new string("hello");
            object obj1 = s1;
            object obj2 = s1;
            object obj3 = new string("hello");

            Console.WriteLine(s1 == obj1); // output: true
            Console.WriteLine(obj1 == obj2); // output: true
            Console.WriteLine(s1 == obj2); // output: true
            Console.WriteLine(s1 == obj3); // output: false



        }
        /// <summary>
        /// A static method that belongs to the Program class.
        /// The method adds two ints and returns the sum
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>The sum of number1 + number2</returns>
        public static int AddTwoNumber(int number1, int number2)
        {
            int sum;
            sum = number1 + number2;
            return sum;
        }
    }

} // a closing brace indicates the end of a block
