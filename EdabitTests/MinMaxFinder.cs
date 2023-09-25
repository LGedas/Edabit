namespace EdabitTests
{
    public class MinMaxFinder
    {
        [Fact]
        public void findMinMax_ArraySizeOf1_returnSameNumberTwice()
        {
            int[] arraySizeOfOne = new int[] { 5 };
            int[] expectedArray = new int[] { 5, 5 };

            int[] actualArray = EdabitTasks.MinMaxFinder.findMinMax(arraySizeOfOne);

            Assert.Equal(actualArray, expectedArray);    
        }

        [Fact]
        public void findMinMax_ArrayMaxMin_returnMinMax()
        {
            int[] arraySizeOfOne = new int[] { 2334454, 5 };
            int[] expectedArray = new int[] { 5, 2334454 };

            int[] actualArray = EdabitTasks.MinMaxFinder.findMinMax(arraySizeOfOne);

            Assert.Equal(actualArray, expectedArray);
        }

        [Fact]
        public void findMinMax_Array_returnMinMax()
        {
            int[] arraySizeOfOne = new int[] { 1, 2, 3, 4, 5 };
            int[] expectedArray = new int[] { 1, 5 };

            int[] actualArray = EdabitTasks.MinMaxFinder.findMinMax(arraySizeOfOne);

            Assert.Equal(actualArray, expectedArray);
        }
    }
}