namespace EdabitTasks
{
    public static class PowerRanger
    {
        public static int  powerRanger(int power, int lowerLimmit, int upperLimmit) 
        {
            int numbersInRange = 0;

            for(int number = 1; Math.Pow(number, power) <= upperLimmit; number++)
            {
                double result = Math.Pow(number, power);
                
                if (result >= lowerLimmit && result <= upperLimmit) 
                {
                    numbersInRange++;
                }
            }

            return numbersInRange;
        }
    }
}
