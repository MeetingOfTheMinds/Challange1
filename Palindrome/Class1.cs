using System;


namespace Palindrome
{
    using System;

    public class PalinDromeRunner
    {

        public bool IsPalindrome(char[] phrase)
        {
            bool result = false;
            string stripedString = GetStrippedString(phrase);

            string reversString = GetReverse(stripedString.ToCharArray());

            for (int i = 0; i != stripedString.Length; i++)
            {
                if (stripedString[i] != reversString[i])
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }


            return result;
        }

        private string GetStrippedString(char[] phrase)
        {
            string resultingBuffer = string.Empty;

            foreach (var letter in new String(phrase).ToLower())
            {
                if (letter >= 'a' && letter <= 'z')
                {
                    resultingBuffer += letter;
                }
            }

            return resultingBuffer;
        }

        private string GetReverse(char[] phrase)
        {
            string result = string.Empty;

            for (int i = phrase.Length - 1; i != -1; i--)
            {
                result += phrase[i];
            }

            return result;
        }

    }
}
