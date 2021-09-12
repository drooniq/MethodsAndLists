
using System;

namespace MethodsAndLists.Core
{
    public class StringListToNumber
    {
        public int ElevatorGoUpAndDown(string[] input)
        {
            /*
                Hissen börjar på våning 0. 
                För varje "UPP" åker den upp en våning
                För varje "NER" åker den ner en våning
                */
            if ( input == null )
            {
                throw new ArgumentException();
            }

            int value = 0;

            foreach (string word in input)
            {
                if ( word == "UPP")
                {
                    value++;
                } else if (word == "NER")
                {
                    value--;
                }
            }


            return value;
        }
    }
}
