using LuciansLusciousLasagna;

namespace LuciansLusciousLasagnaTests
{
    public class LuciansLusciousLasagnaTests
    {
        [Fact]
        public void Expected_minutes_in_oven()
        {
            Assert.Equal(40, new Lasagna().ExpectedMinutesInOven());
        }

        [Fact]
        public void Remaining_minutes_in_oven_after_twenty_five_minutes()
        {
            Assert.Equal(15, new Lasagna().RemainingMinutesInOven(25));
        }

        [Fact]
        public void Remaining_minutes_in_oven_after_thirty_three_minutes()
        {
            Assert.Equal(7, new Lasagna().RemainingMinutesInOven(33));
        }

        [Fact]
        public void Preparation_time_in_minutes_for_one_layer()
        {
            Assert.Equal(2, new Lasagna().PreparationTimeInMinutes(1));
        }

        [Fact]
        public void Preparation_time_in_minutes_for_multiple_layers()
        {
            Assert.Equal(8, new Lasagna().PreparationTimeInMinutes(4));
        }

        [Fact]
        public void Elapsed_time_in_minutes_for_one_layer()
        {
            Assert.Equal(32, new Lasagna().ElapsedTimeInMinutes(1, 30));
        }

        [Fact]
        public void Elapsed_time_in_minutes_for_multiple_layers()
        {
            Assert.Equal(16, new Lasagna().ElapsedTimeInMinutes(4, 8));
        }
    }
}