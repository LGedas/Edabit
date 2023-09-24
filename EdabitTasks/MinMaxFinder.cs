using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitTasks
{
    //Dificulty: Easy
    //Task: Find the Smallest and Biggest Numbers
    //output: array = {Min, Max} 

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
