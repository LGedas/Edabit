namespace EdabitTests
{
    public class AreaCalculator
    {
        [Fact]
        public void triangleArea_7and4_return14() 
        {
            int triangleBase = 7;
            int triangleHeight = 4;
            int expected = 14;

            int actual = EdabitTasks.AreaCalculator.triangleArea(triangleBase, triangleHeight);

            Assert.Equal(expected, actual); 
        }
    }
}
