
using System;

namespace MethodsAndLists.Core
{
    public class StringToBool
    {
        public bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentException();
            }

            if (input.Length == 0 )
            {
                return true;
            }

            foreach (char tkn in input)
            {
                if (!Char.IsLetterOrDigit(tkn))
                {
                    throw new ArgumentException();
                }
            }

            int startPos = 0, endPos = input.Length - 1;
            char charStartPos, charEndPos;

            while (startPos <= endPos)
            {
                charStartPos = input[startPos];
                charEndPos = input[endPos];

                if (charStartPos != charEndPos)
                {
                    return false;
                }
                startPos++;
                endPos--;
            }

            return true;
        }

        public bool IsZipCode(string text)
        {
            if (text == null)
            {
                return false;
            }

            if (text.Length != 6)
            {
                return false;
            }

            int subDigits = 0;

            if (int.TryParse( text.Substring(0,3), out subDigits))
            {
                if (subDigits < 100)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            if (int.TryParse(text.Substring(4, 2), out subDigits))
            {
                if (subDigits < 10)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
