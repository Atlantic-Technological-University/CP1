/* 
 * Filename: Lasagna.cs
 * Description: A skeleton class for a C# practical exercise covering basic programming tasks
 * such as declaring variables, methods, returning data from methods. 
 */


namespace LuciansLusciousLasagna
{
    public class Lasagna
    {
        /// <summary>
        /// The <c>ExpectedMinutesInOven</c> method retuns how many minutes the lasagna should be in the 
        /// oven. According to the cookbook, the expected oven time is forty minutes. 
        /// </summary>
        /// <returns>The expected time in the oven according to the recipe.</returns>
        public int ExpectedMinutesInOven()
        {
            // TODO: Implement the 'ExpectedMinutesInOven()' method
            return 40;
        }
        /// <summary>
        /// The RemainingMinutesInOven method that takes the actual minutes the lasagna has been in
        /// the oven as a parameter and returns how many minutes the lasagna still has to remain in
        /// the oven, based on the expected oven time in minutes from the previous task.
        /// </summary>
        /// <param name="durationInOven">an integer represent the number of minutes the ladagna has
        /// been in the oven</param>
        /// <returns>An integer representing how many minutes the lasagna still has to remain
        /// in the oven.</returns>
        public int RemainingMinutesInOven(int durationInOven)
        {
            // TODO: Implement the 'RemainingMinutesInOven()' method
            return 40 - durationInOven;
        }

        /// <summary>
        /// The method <c>PreparationTimeInMinutes</c> takes the number of layers you added to the
        /// lasagna as a parameter and returns how many minutes you spent preparing the lasagna,
        /// assuming each layer takes you 2 minutes to prepare.
        /// </summary>
        /// <param name="layers">An integer representing the number of layers that the lasagna has.</param>
        /// <returns>An integer representing the number of minutes it takes to prepare the lasagna.</returns>
        public int PreparationTimeInMinutes(int layers)
        {
            // TODO: define the 'PreparationTimeInMinutes()' method
            return layers * 2;
        }

        /// <summary>
        /// The <c>ElapsedTimeInMinutes</c> method returns how many minutes you've worked on cooking
        /// the lasagna, which is the sum of the preparation time in minutes, and the time in
        /// minutes the lasagna has spent in the oven at the moment.
        /// </summary>
        /// <param name="layers">An interger value representing the the number of layers you added
        /// to the lasagna</param>
        /// <param name="minutesInOven">An integer representing the number of layers you added to
        /// the lasagna</param>
        /// <returns>An integer value for the total time it has taken to prepare and cook the
        /// lasagna so far.</returns>
        public int ElapsedTimeInMinutes(int layers, int minutesInOven)
        {
            // TODO: define the 'ElapsedTimeInMinutes()' method
            int prepMinutes = this.PreparationTimeInMinutes(layers) + minutesInOven;
            return prepMinutes;
        }
    }
}
