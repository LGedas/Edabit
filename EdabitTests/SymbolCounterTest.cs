using EdabitTasks;

namespace EdabitTests
{
    public class SymbolCounterTest
    {
        [Fact]
        public void countLetters_Hello_return5()
        {
            string testableString = "Hello";
            int expected = 5;

            int actual = SymbolCounter.countLetters(testableString);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void countDigits_Hello5_return1()
        {
            string testableString = "Hello5";
            int expected = 1;

            int actual = SymbolCounter.countDigits(testableString);

            Assert.Equal(expected, actual);
        }
    }
}
