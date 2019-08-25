using System;
using System.Text;
using System.Linq;

namespace TextValidation
{
    public static class Palindrome
    {
        private const int MINIMUM_PALINDROME_LENGTH = 2;

        /// <summary>
        /// Palindrome evaluation of string.
        /// </summary>
        /// <remarks>
        /// Spaces and punctuation ignored.        
        /// </remarks>        
        /// <returns>True if string is a palindrome.</returns>
        public static bool IsPalindrome(this string text)
        {
            return text.IsPalindrome(MINIMUM_PALINDROME_LENGTH);
        }

        /// <summary>
        /// Palindrome evaluation of string.
        /// </summary>
        /// <remarks>
        /// Minimum 2 characters in length. Spaces and punctuation ignored.        
        /// </remarks>        
        /// <returns>True if string is a palindrome.</returns>
        public static bool IsPalindrome(this string text, int minimumLength)
        {
            // Remove puncation.  
            StringBuilder noPunctuationText = new StringBuilder();

            foreach (char textCharacter in text)
            {
                if (Char.IsPunctuation(textCharacter) == false && Char.IsSeparator(textCharacter) == false)
                {
                    noPunctuationText.Append(textCharacter);
                }
            }

            string cleaned = noPunctuationText.ToString();

            if (cleaned.Length < minimumLength)
            {
                return false;
            }

            string reversed = new string(cleaned.Reverse().ToArray<char>());

            if (reversed.Equals(cleaned, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
