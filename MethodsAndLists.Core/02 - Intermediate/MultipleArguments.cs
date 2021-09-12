using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class MultipleArguments
    {
        public List<string> SomeToUpper(List<string> list, List<bool> toUpper)
        {
            if (list == null || toUpper == null || list.Count != toUpper.Count)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (toUpper[i])
                {
                    list[i] = list[i].ToUpper();
                }
            }

            return list;
        }

        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            if ( numbers == null )
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= 100;
            }

            return numbers;
        }

        public List<string> NearbyElements(int position, List<string> list)
        {
            if ( position >= list.Count || position < 0 )
            {
                throw new ArgumentException();
            }

            List<string> newList = new List<string>();

            int startPos = position - 1;
            int endPos = position + 1;

            if (startPos < 0)
            {
                startPos = 0;
            }

            if (endPos >= list.Count)
            {
                endPos = list.Count - 1;
            }

            for (int i = startPos; i <= endPos; i++)
            {
                newList.Add(list[i]);
            }

            return newList;
        }

        public List<List<int>> MultiplicationTable(int rowMax, int colMax)
        {
            if(rowMax == 0 || colMax == 0)
            {
                throw new ArgumentException();
            }

            List<List<int>> newList = new List<List<int>>();

            for (int i = 1; i <= rowMax; i++)
            {
                List<int> rowList = new List<int>();
                newList.Add(rowList);

                for (int j = 1; j <= colMax; j++)
                {
                    newList[i-1].Add(i * j);
                }
            }

            return newList;
        }

        public int ComputeSequenceSumOrProduct(int toNumber, bool sum)
        {
            if (sum)
            {
                return ComputeSequence(toNumber, ComputeMethod.Sum);
            }
            else
            {
                return ComputeSequence(toNumber, ComputeMethod.Product);
            }
        }


        public int[] CombineLists(int[] list1, int[] list2)
        {
            int i = 0;
            int j = 0;

            int[] newList = new int[list1.Length + list2.Length];
            int position = 0;

            while (i < list1.Length || j < list2.Length)
            {
                if (i < list1.Length)
                {
                    newList[position++] = list1[i];
                }
                if (j < list2.Length)
                {
                    newList[position++] = list2[j];
                }
                i++;
                j++;
            }

            return newList;
        }

        public int[] RotateList(int[] list, int rotation)
        {
            if ( list == null)
            {
                throw new ArgumentException();
            }

            if(list.Length == 0)
            {
                return new int[] { };
            }

            int startPos = (list.Length - rotation) % list.Length;


            int[] newList = new int[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[(startPos + i) % list.Length];
            }

            return newList;
        }

        public int ComputeSequence(int v, object sum)
        {
            if (v <= 0)
            {
                throw new ArgumentException();
            }

            int value = v;

            while (--v > 0)
            {
                switch (sum)
                {
                    case ComputeMethod.Sum:
                        value += v;
                        break;
                    case ComputeMethod.Product:
                        value *= v;
                        break;
                }
            }

            return value;
        }
    }
}
