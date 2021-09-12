using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class NumberListToStringList
    {
        public List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> list)
        {
            /*
            Negativa tal => "ZIP"
            Positiva tal => "ZAP"
            Noll         => "BOING"
            */
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException();
            }

            List<string> newList = new List<string>();

            foreach (var item in list)
            {
                if (item == 0)
                {
                    newList.Add("BOING");
                } else if (item < 0)
                {
                    newList.Add("ZIP");
                } else if (item > 0)
                {
                    newList.Add("ZAP");
                }
            }

            return newList;
        }

        public List<string> LongOrShort(List<int> list)
        {
            // Skapa en lista av strängar som meddelar om personen är kort eller lång (över 160cm). Hoppa över orimliga värden
            // List<string> expected = new List<string> { "170cm är långt", "130cm är kort", "205cm är långt", "180cm är långt" };

            if (list == null || list.Count == 0)
            {
                throw new ArgumentException();
            }

            List<string> newList = new List<string>();

            foreach (int item in list)
            {
                if (item >= 0 && item <= 250)
                {
                    newList.Add(item.ToString() + "cm är " + ((item >= 160) ? "långt" : "kort"));
                }
            }

            return newList;

        }

        public List<string> AddStars(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException();
            }

            List<string> newList = new List<string>();

            foreach (int value in list)
            {
                newList.Add($"***{value}***");
            }

            return newList;
        }

        public List<string> AddStarsToNumbersHigherThan1000(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException();
            }

            List<string> newList = new List<string>();

            foreach (int value in list)
            {
                if (value > 1000)
                {
                    newList.Add($"***{value}***");
                }
                else
                {
                    newList.Add(value.ToString());
                }
            }

            return newList;
        }
    }
}