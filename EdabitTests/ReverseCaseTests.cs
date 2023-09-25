using EdabitTasks;

namespace EdabitTests
{
    public class ReverseCaseTests
    {
        [Fact]
        public void reverseCase_Happy_Birthday_revertedCorrectly()
        {
            string input = "Happy Birthday";
            string expected = "hAPPY bIRTHDAY";

            string actual = ReverseCase.reverseCase(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void reverseCase_MANY_THANKS_revertedCorrectly()
        {
            string input = "MANY THANKS";
            string expected = "many thanks";

            string actual = ReverseCase.reverseCase(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void reverseCase_sPoNtAnEoUs_revertedCorrectly()
        {
            string input = "sPoNtAnEoUs";
            string expected = "SpOnTaNeOuS";

            string actual = ReverseCase.reverseCase(input);

            Assert.Equal(expected, actual);
        }

    }
}
