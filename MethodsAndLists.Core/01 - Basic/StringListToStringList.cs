
using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class StringListToStringList
    {
        public IEnumerable<string> GetEverySecondElement(string[] input)
        {
            if (input == null)
            {
                return null;
            }

            List<string> newList = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if ( (i+1) % 2 == 0)
                {
                    newList.Add(input[i]);
                }
            }

            return newList;
        }
    }
}
