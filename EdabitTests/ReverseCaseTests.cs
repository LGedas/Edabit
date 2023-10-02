using EdabitTasks;

namespace EdabitTests
{
    public class ReverseCaseTests
    {
        [Theory]
        [InlineData("Happy Birthday", "hAPPY bIRTHDAY")]
        [InlineData("MANY THANKS", "many thanks")]
        [InlineData("sPoNtAnEoUs", "SpOnTaNeOuS")]
        public void reverseCaseTheory(string input, string expected)
        {
            string actual = ReverseCase.reverseCase(input);

            Assert.Equal(expected, actual);
        }
    }
}
