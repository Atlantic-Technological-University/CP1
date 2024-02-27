/* 
 * Filename: Badge.cs
 * Description: A skeleton class for a C# practical exercise covering nullability
 * 
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/concept/tim-from-marketing
 */

/*
* Instructions:
* In this exercise you'll be writing code to print name badges for factory employees.
* 
* Due to a quirk in the computer system, new employees occasionally don't yet have an
* ID when they start working at the factory. As badges are required, they will receive
* a temporary badge without the ID prefix.
* 
* Even the factory's owner has to wear a badge at all times. However, an owner does not
* have a department. In this case, the label should print "OWNER" instead of the department name. 
* 
*/
using System.Text;

namespace TimFromMarketing
{
    public static class Badge
    {
        /// <summary>
        /// The <c>Print</c> method prints the names of employee badges. All employees have an
        /// ID, name and department name. Employee badge label are formatted as follows:
        /// "[d] - name - DEPARTMENT". 
        /// Example input: (734, "Ernest Johnny Payne", "Strategic Communication")
        /// Example output: "[734] - Ernest Johnny Payne - STRATEGIC COMMUNICATION"
        /// 
        /// Example input: (null, "Lisa Magee", "Public Relations")
        /// Example output: "Lisa Magee - PUBLIC RELATIONS"
        /// 
        /// Example input: (1, "Dorothy Roberts ", null)
        /// Example output: "[1] - Dorothy Roberts  - OWNER"
        /// 
        /// </summary>
        /// <param name="id">The employee's ID</param>
        /// <param name="name">The employee's name</param>
        /// <param name="department">The employee's department</param>
        /// <returns>A <c>string</c> representing the text for the badge for printing.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Print(int? id, string name, string? department)
        {
            // Todo: implement the Print method
            throw new NotImplementedException("Please implement the (static) Badge.Print() method");
        }
    }
}
