using System;

namespace EdabitTasks
{
    public class ReverseCase
    {
        private static char reverseLetter(char letter)
        {
            if (char.IsUpper(letter))
            {
                return char.ToLower(letter);                
            }

            if (char.IsLower(letter))
            {
                return char.ToUpper(letter);                
            }

            return letter;
        }

        public static string reverseCase(string letters) 
        {
            string revertedLetters = string.Empty;

            foreach (char letter in letters) 
            {
                revertedLetters += reverseLetter(letter);
            }

            return revertedLetters;
        }
    }
}
