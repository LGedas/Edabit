using EdabitTasks;

namespace EdabitTests
{
    public class MinMaxFinderTests
    {
        [Fact]
        public void findMinMax_ArraySizeOf1_returnSameNumberTwice()
        {
            int[] arraySizeOfOne = new int[] { 5 };
            int[] expectedArray = new int[] { 5, 5 };

            int[] actualArray = MinMaxFinder.findMinMax(arraySizeOfOne);

            Assert.Equal(actualArray, expectedArray);    
        }

        [Fact]
        public void findMinMax_ArrayMaxMin_returnMinMax()
        {
            int[] arrayMaxMin = new int[] { 2334454, 5 };
            int[] expectedArray = new int[] { 5, 2334454 };

            int[] actualArray = MinMaxFinder.findMinMax(arrayMaxMin);

            Assert.Equal(actualArray, expectedArray);
        }

        [Fact]
        public void findMinMax_Array_returnMinMax()
        {
            int[] givenArray = new int[] { 1, 2, 3, 4, 5 };
            int[] expectedArray = new int[] { 1, 5 };

            int[] actualArray = MinMaxFinder.findMinMax(givenArray);

            Assert.Equal(actualArray, expectedArray);
        }
    }
}