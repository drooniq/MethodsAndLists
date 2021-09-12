using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class StringToObjectList
    {
        public List<City> ParseCities(string cityData)
        {
            if ( cityData == null)
            {
                throw new ArgumentException();
            }

            List<City> cities = new List<City>();

            if (cityData == "")
            {
                return cities;
            }

            cityData = cityData.Replace("  ", "").Trim();

            string[] eachCityString = string.Concat(cityData.Where(c => (Char.IsLetterOrDigit(c) || c == ';' || c == ',') || c == ' ')).Split(';');
            string[] cityParts;
            int population = 0;

            for (int i = 0; i < eachCityString.Length; i++)
            {
                cityParts = eachCityString[i].Split(",");
                if (cityParts.Length > 1)
                {
                    if (!int.TryParse(cityParts[1], out population))
                    {
                        throw new ArgumentException("could not parse Population = " + cityParts[1]);
                    }
                    cities.Add(new City(cityParts[0], population));
                }
            }

            return cities;
        }
    }

    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public City()
        {
        }

        public City( string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
}
