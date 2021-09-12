using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class StringListToBool
    {
        public bool AllWordsAreFiveLettersOrLonger(IEnumerable<string> list)
        {
            if ( list == null )
            {
                return false;
            }

            foreach (string value in list)
            {
                if ( value.Length < 5)
                {
                    return false;
                }
            }

            return true;
        }

        public bool AllWordsAreFiveLettersOrLonger_Linq(IEnumerable<string> list)
        {
            if ( list == null )
            {
                return false;
            }

            IEnumerable<string> wordQuery =
                from word in list
                where word.Length >= 5
                select word;

            return wordQuery.Count() == list.Count();
        }
    }
}
