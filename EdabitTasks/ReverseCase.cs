using System.Text;

namespace EdabitTasks
{
    public static class ReverseCase
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
            StringBuilder revertedLetters = new StringBuilder();

            foreach (char letter in letters) 
            {
                revertedLetters.Append(reverseLetter(letter));
            }

            return revertedLetters.ToString();
        }
    }
}
