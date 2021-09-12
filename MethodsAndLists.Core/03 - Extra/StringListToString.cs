
using System;

namespace MethodsAndLists.Core
{
    public class StringListToString
    {
        public string Frame(string[] v)
        {
            if (v == null)
            {
                throw new ArgumentException();
            }

            if (v.Length == 0)
            {
                return "";
            }

            string newString = "";
            string starString = "";

            // find the longest word/char in array and save amount of characters
            int longest = 0;

            foreach (string word in v)
            {
                if (word.Length > longest)
                {
                    longest = word.Length;
                }
            }

            // add 4 stars to make up for the border margins etc.
            longest += 4;

            while( longest-- > 0)
            {
                starString += "*";
            }

            newString = starString;

            foreach (var word in v)
            {
                newString += "\n" + "* " + new string(word).PadRight(starString.Length - 4) + " *";
            }

            newString += "\n" + starString;


            return newString;
        }
    }
}
