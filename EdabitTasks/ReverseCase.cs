using System;

namespace EdabitTasks
{
    public class ReverseCase
    {
        public static string reverseCase(string letters) 
        {
            string revertedLetters = string.Empty;

            foreach (char letter in letters) 
            {
                if (char.IsUpper(letter))
                {
                    revertedLetters += char.ToLower(letter);
                    continue;
                }

                if (char.IsLower(letter))
                {
                    revertedLetters += char.ToUpper(letter);
                    continue;
                }

                revertedLetters += letter;
            }

            return revertedLetters;
        }
    }
}
