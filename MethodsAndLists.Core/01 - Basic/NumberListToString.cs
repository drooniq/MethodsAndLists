using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class NumberListToString
    {
        public string ReportFirstAndLastValue(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException();
            }

            return $"Första siffran är {list[0].ToString()} och sista siffran är {list[list.Count - 1].ToString()}";

        }

        public string ReportNumberOfNegativeValues(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException();
            }
 
            int integerCounter = 0;

            foreach (int value in list)
            {
                if (value < 0)
                {
                    integerCounter++;
                }
            }

            switch (integerCounter)
            {
                case 0:
                    return "Jippi! Det finns inga negativa tal i listan";
                case 1:
                    return "Det finns ett negativt tal i listan";
                default:
                    return $"Det finns {integerCounter} st negativa tal i listan";
            }
        }
    }
}