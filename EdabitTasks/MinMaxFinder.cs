namespace EdabitTasks
{
    public static class MinMaxFinder
    {
        public static int[] findMinMax(int[] array)
        {
            int min = array.Min();
            int max = array.Max();
            int[] reusult = new int[] {min, max};

            return reusult;
        }
    }
}
