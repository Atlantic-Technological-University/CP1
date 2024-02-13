using Logline;
using System;

namespace LogLineTests
{
    public class TestLogLine
    {
        [Theory]
        [InlineData("[ERROR]: Stack overflow", "Stack overflow")]
        [InlineData("[WARNING]: Disk almost full", "Disk almost full")]
        [InlineData("[INFO]: File moved", "File moved")]
        [InlineData("[WARNING]:   \tTimezone not set  \r\n", "Timezone not set")]
        public void MessageGivenValidInputReturnsValidValues(string input, string expectedOutput)
        {
            // Arrange & Act
            string actualResult = LogLine.Message(input);
                        
            // Assert
            Assert.Equal(expectedOutput, actualResult);

        }

        [Theory]
        [InlineData("[ERROR]: Stack overflow", "error")]
        [InlineData("[WARNING]: Disk almost full", "warning")]
        [InlineData("[INFO]: File moved", "info")]

        public void LogLevelGivenValidInputReturnsCorrectOuput(string input, string expectedOutput)
        {
            // Arrange & Act
            string actualResult = LogLine.LogLevel(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);

        }

        [Theory]
        [InlineData("[ERROR]: Segmentation fault", "Segmentation fault (error)")]
        [InlineData("[WARNING]: Decreased performance", "Decreased performance (warning)")]
        [InlineData("[INFO]: Disk defragmented", "Disk defragmented (info)")]
        [InlineData("[ERROR]: \t Corrupt disk\t \t \r\n", "Corrupt disk (error)")]

        public void ReformatGivenValidInputReturnsCorrectOuput(string input, string expectedOutput)
        {
            // Arrange & Act
            string actualResult = LogLine.Reformat(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);

        }
    }
}