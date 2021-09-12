using System;

namespace MethodsAndLists.Core
{
    public class NumberToString
    {
        public string Triangle(int v)
        {
            return Triangle(v, '*');
        }

        public string TriangleReversed(int v)
        {
            char[] charArray = Triangle(v).ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string Triangle(int v1, char v2)
        {
            if (v1 < 0)
            {
                throw new ArgumentException();
            }

            if (v1 == 0)
            {
                return "";
            }

            string returnString = v2.ToString();
            string subString = "\n" + v2.ToString();

            while (v1-- > 1)
            {
                subString += v2.ToString();
                returnString += subString;
            }

            return returnString;
        }
    }
}
