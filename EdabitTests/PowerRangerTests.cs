using EdabitTasks;

namespace EdabitTests
{
    public class PowerRangerTests
    {
        [Theory]
        [InlineData(2, 49, 65, 2)]
        [InlineData(3, 1, 27, 3)]
        [InlineData(10, 1, 5, 1)]
        [InlineData(5, 31, 32, 1)]
        [InlineData(4, 250, 1300, 3)]
        public void countNumbersTheory(int power, double lowerLimmit, double upperLimit, int expected)
        {
            int actual = PowerRanger.countNumbers(power, lowerLimmit, upperLimit);

            Assert.Equal(expected, actual);
        }
    }
}
