// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

namespace SwitchExpression
{
    // A set of simple backing classes for the Switch expression example
    public class Employee
    {
        public string? EmployeeName { get; set; }
        public Employee()
        {
            EmployeeName = "Milo Mindbender";
        }
    }
    public class Developer : Employee { }
    public class Manager : Employee { }
}
