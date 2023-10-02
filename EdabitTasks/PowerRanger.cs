using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EdabitTasks
{
    public static class PowerRanger
    {
        private static IEnumerable<double> getNumbers(int power, double lowerLimmit, double upperLimmit)
        {
            int number = 1;
            double result = 1; //1^N=1
            
            do 
            {              
                if (lowerLimmit <= result)
                {
                    yield return result;
                }

                number++;
                result = Math.Pow(number, power);

            } while (result <= upperLimmit);
        }

        public static int countNumbers(int power, double lowerLimmit, double upperLimmit)
        {
            return getNumbers(power, lowerLimmit, upperLimmit).Count();
        }
    }
}
