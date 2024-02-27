/* 
 * Filename: Appointment.cs
 * Description: A skeleton class for a C# practical exercise covering usage of the DatTime C# 
 * class. 
 *   
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/concept/booking-up-for-beauty
 */

/*
 * In this exercise you'll be working on an appointment scheduler for a beauty salon in Letterkenny that opened on September 15th in 2012.
 * You have four tasks, which will all involve appointment dates. The dates and times will use one of the following three formats:
 * "07/25/2019 13:45:00"
 * "July 25, 2019 13:45:00"
 * "Thursday, July 25, 2019 13:45:00"
 * 
*/

using System.Globalization;
using System.Text;

namespace BookingUpForBeauty
{
    public static class Appointment
    {

        /// <summary>
        /// The <c>Schedule</c> method parses a textual representation of an appointment date into 
        /// the corresponding DateTime format:
        /// Input: 25/07/2019 13:45:00
        /// Output: new DateTime(2019, 7, 25, 13, 45, 0)
        /// </summary>
        /// <param name="appointmentDateDescription">A string description of the date in time
        /// </param>
        /// <returns>A valid DateTime object.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static DateTime Schedule(string appointmentDateDescription)
        {
            //TODO: Implement the method as described in the document comments. 
            throw new NotImplementedException("Please implement the (static) Appointment.Schedule() method");
        }

        /// <summary>
        /// The <c>HasPassed</c> method takes an appointment date and checks if the appointment 
        /// was somewhere in the past:
        /// Input: (1999, 12, 31, 9, 0, 0
        /// Output: True
        /// </summary>
        /// <param name="appointmentDateDescription">A string description of the date in time
        /// </param>
        /// <returns>A <c>bool</c> true if the date is in the past otherwise false.
        /// </returns> 
        /// <exception cref="NotImplementedException"></exception>
        public static bool HasPassed(DateTime appointmentDate)
        {
            //TODO: Implement the method as described in the document comments. 
            throw new NotImplementedException("Please implement the (static) Appointment.HasPassed() method");
        }

        /// <summary>
        /// The <c>IsAfternoonAppointment</c> method takes an appointment date and checks if the 
        /// appointment is in the afternoon (>= 12:00 and < 18:00):
        /// Input: new DateTime(2019, 03, 29, 15, 0, 0)
        /// Output: true
        /// </summary>
        /// <param name="appointmentDateDescription">A string description of the date in time
        /// </param>
        /// <returns><c>bool</c>true if time is in the afteroon otherwise false.
        /// </returns> 
        /// <exception cref="NotImplementedException"></exception>
        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            //TODO: Implement the method as described in the document comments. 
            throw new NotImplementedException("Please implement the (static) Appointment.IsAfternoonAppointment() method");
        }

        /// <summary>
        /// The <c>Description</c> method takes an appointment date and returns a description of 
        /// that date and time:
        /// Input: new DateTime(2019, 03, 29, 15, 0, 0)
        /// Output: "You have an appointment on 29/3/2019 3:00:00 PM."
        /// </summary>
        /// <param name="appointmentDate"> a valid instance of <c>DateTime</c></param> 
        /// <returns><c>string</c> describing the date and time of the appointment.</returns> 
        /// <exception cref="NotImplementedException"></exception>
        public static string Description(DateTime appointmentDate)
        {
            //TODO: Implement the method as described in the document comments. 
            throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
            // See: https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
        }

        /// <summary>
        /// The <c>AnniversaryDate</c> method returns this year's anniversary date, 
        /// which is September 15th:
        /// Output: new DateTime(2024, 9, 15, 0, 0, 0) //assuming it is 2024!
        /// </summary>
        /// <returns>returns a new <c>DateTime</c> object for the 15th of September this year</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static DateTime AnniversaryDate()
        {
            //TODO: Implement the method as described in the document comments. 
            throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
        }
    }
}
