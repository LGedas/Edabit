using EdabitTasks;
using System.ComponentModel.Design;

namespace EdabitTests
{
    public class SymbolCounterTest
    {
        [Fact]
        public void countAll_string_countsCorectly()
        {
            string expected = "{ LETTERS =  7, DIGITS =  3 }";
            string input = "H3ll0 Wor1d";

            string actual = SymbolCounter.countAll(input);

            Assert.Equal(expected, actual);
        }
    }
}
