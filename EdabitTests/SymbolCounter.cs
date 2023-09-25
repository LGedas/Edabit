namespace EdabitTests
{
    public class SymbolCounter
    {
        [Fact]
        public void countAll_string_countsCorectly()
        {
            string expected = "{ LETTERS =  7, DIGITS =  3 }";
            string testableString = "H3ll0 Wor1d";

            string actual = EdabitTasks.SymbolCounter.countAll(testableString);

            Assert.Equal(expected, actual);
        }
    }
}
