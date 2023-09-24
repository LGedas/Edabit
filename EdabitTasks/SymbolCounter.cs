using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitTasks
{
    public static class SymbolCounter
    {
        public static int countDigits(string text)
        {
            int sum = 0;

            foreach (char symbol in text)
            {
                if (Char.IsDigit(symbol))
                {
                    sum++;
                }
            }

            return sum;
        }

        public static int countLetters(string text)
        {
            int sum = 0;

            foreach (char symbol in text)
            {
                if (Char.IsLetter(symbol))
                {
                    sum++;
                }
            }

            return sum;
        }

    }
}
