/* 
 * Filename: CarsAssemble.cs
 * Description: A skeleton class for a C# practical exercise covering usage of if/else 
 * and switch statements. 
 *  
 * 
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/concept/cars-assemble
 */

/*
 * Instructions:
 * In this exercise you'll be writing code to analyze the production of an assembly line in a car 
 * factory. The assembly line's speed can range from 0 (off) to 10 (maximum).
 * 
 * At its lowest speed (1), 221 cars are produced each hour. The production increases linearly with
 * the speed. So with the speed set to 4, it should produce 4 * 221 = 884 cars per hour. However, 
 * higher speeds increase the likelihood that faulty cars are produced, which then have to be 
 * discarded.
 * 
 */


using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assembly
{
    public static class AssemblyLine
    {
        /// <summary>
        /// The <c>SuccessRate</c> method calculates the ratio of an item being created without
        /// error for a given speed. The following table shows how speed influences the success
        /// rate:
        /// 0: 0% success rate.
        /// 1 to 4: 100% success rate.
        /// 5 to 8: 90% success rate.
        /// 9: 80% success rate.
        /// 10: 77% success rate.
        /// Sample input: 10
        /// Output: 0.77
        /// </summary>
        /// <param name="speed"></param> an integer representing the speed of the assembly line.
        /// <returns>A <c>double</c> representing the percentage of error free items at the given
        /// speed.</returns>
        public static double SuccessRate(int speed)
        {
            // Todo: implement the method SuccessRate
            throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
        }

        /// <summary>
        /// The <c>ProductionRatePerHour</c> method calculates the assembly line's production rate
        /// per hour, taking into account its success rate. At its lowest speed (1)the production
        /// line produces 221 cars each hour. 
        /// Input: 6
        /// Output: 1193.4
        /// </summary>
        /// <param name="speed"></param> an integer representing the speed of the assembly line.
        /// <returns>A <c>double</c> representing the number of cars produced each hour
        /// taking into account the successrate. </returns>
        /// <exception cref="NotImplementedException"></exception>
        public static double ProductionRatePerHour(int speed)
        {
            // Todo: implement the ProductionRatePerHour method
            throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
        }

        /// <summary>
        /// The <c>WorkingItemsPerMinute</c> method calculates the assembly line's production rate
        /// per hour, taking into account its success rate:
        /// Input: 6
        /// Output: 19
        /// </summary>
        /// <param name="speed"></param> an integer representing the speed of the assembly line.
        /// <returns>An <c>int</c> representing the number of cars produced each minute.</returns>
        public static int WorkingItemsPerMinute(int speed)
        {
            // Todo: Implement the WorkingItemsPerMinute method
            throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        }
    }
}
