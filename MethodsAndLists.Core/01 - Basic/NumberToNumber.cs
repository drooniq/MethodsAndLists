
using System;

namespace MethodsAndLists.Core
{
    public class NumberToNumber
    {
        public int SumNumbers(int from, int to)
        {
            if ( from > to )
            {
                throw new ArgumentException();
            }

            int sum = 0;
            for (int i = from; i <= to; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int SumNumbersTo(int input)
        {
            if (input <= 0)
            {
                throw new ArgumentException();
            }

            int value = 0;

            for (int i = 0; i <= input; i++)
            {
                value += i;
            }

            return value;
        }

        public int SumNumbersDividedByThreeOrFive(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException();
            }

            int sum = 0;

            for (int i = 0; i <= input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
