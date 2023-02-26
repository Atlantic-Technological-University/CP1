// Written by Dr. Shane Wilson.
// The author licenses this file to you under the MIT license.
// See the LICENSE file in the solution root for more information.

namespace Logline
{
    /// <summary>
    /// The LogLine class provides starter code for the Week 6 practical exercise for commerical 
    /// programming 1. The solution contains a second project called LogLineTests which includes 
    /// unit test to test if your code works as required. You can run the tests by:
    /// 1. Build the solution (ensure both the Logline and LogLineTests projects build.
    /// 2. Display the test explorer window by clicking View->Test Explorer.
    /// 3. Click on the "run all tests" button (green arrow) to run each unit test.
    /// 
    /// A green tick means your code passed the test. A Red X means it failed the test.
    /// You can examine the expected and actual output of each test. You can also put a breakpoint
    /// in tests and run them through the debugger. Right click on a test and select "debug" to run
    /// a test through the debugger.
    /// </summary>
    public class LogLine
    {
        /// <summary>
        /// The Message method should return a log line's message. 
        /// Example input: "[ERROR]: Invaid operation"
        /// Example output: "Invald operation"
        /// </summary>
        /// <param name="logLine">The log message</param>
        /// <returns>A string containing just the message element of the log</returns>
        public static string Message(string logLine)
        {
            // TODO - Implement the function
            throw new NotImplementedException("Implement the Message function to return just the message string");
        }

        /// <summary>
        /// The LogLevel method should return a log line's log level, in lower case.
        /// Example input: "[ERROR]: Invaid operation"
        /// Example output: "error"
        /// </summary>
        /// <param name="logLine"></param>
        /// <returns>A lowercase string containing the log level</returns>
        public static string LogLevel(string logLine)
        {
            /// TODO - Implement the function
            throw new NotImplementedException("Implement the LogLevel method to return the Log level");
        }

        /// <summary>
        /// The Reformat method should reformat the log line, putting the message first and the 
        /// log level after it in parentheses. The log level should be lowercase.
        /// Example input: "[INFO]: operation completed"
        /// Example output: "Operation completed (info)"
        /// </summary>
        /// <param name="logLine">The log message</param>
        /// <returns></returns>
        public static string Reformat(string logLine)
        {
            /// TODO - Implement the function
            throw new NotImplementedException("Implement the Reformat method to return the message then log level");
        }
    }
}
