using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class NumberListToNumberList
    {
        public List<int> Add100ToEachNumber(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            List<int> newList = new List<int>();

            foreach (int value in input)
            {
                newList.Add(value + 100);
            }

            return newList;
        }

        public List<int> Add50ToFirstThreeElements(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            List<int> newList = new List<int>();

            int counter = 0;

            foreach (int value in input)
            {
                if ( counter++ < 3)
                {
                    newList.Add(value + 50);
                }
                else
                {
                    newList.Add(value);
                }
            }

            return newList;
        }

        public List<int> Add70ToEverySecondElement(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            List<int> newList = new List<int>();

            int counter = 1;

            foreach (int value in input)
            {
                if ( counter++ % 2 == 0 )
                {
                    newList.Add(value + 70);
                }
                else
                {
                    newList.Add(value);
                }
            }

            return newList;
        }

        public List<int> DivideEachNumberBy100(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            List<int> newList = new List<int>();

            foreach (int value in input)
            {
                newList.Add(value / 100);
            }

            return newList;
        }

        public List<int> GetNumbersDividableByFive(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            List<int> newList = new List<int>();

            foreach (int value in input)
            {
                if (value % 5 == 0)
                {
                    newList.Add(value);
                }
            }

            return newList;
        }

        public List<int> GetNumbersHigherThan1000(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            List<int> newList = new List<int>();

            foreach (int value in input)
            {
                if (value > 1000)
                {
                    newList.Add(value);
                }
            }

            return newList;
        }

        public List<int> NegateEachNumber(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            List<int> newList = new List<int>();

            foreach (int value in input)
            {
                newList.Add(-value);
            }

            return newList;
        }

        public List<int> CombineTwoMethods(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            return DivideEachNumberBy100(NegateEachNumber(input));
        }
    }
}