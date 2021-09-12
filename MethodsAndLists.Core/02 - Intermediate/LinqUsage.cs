using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.Core
{
    public class LinqUsage
    {
        public List<Person> FindAllPersonsOverAge(List<Person> personList, int age)
        {
            List<Person> ageCriteria =
                (from pers in personList
                 where pers.Age > age
                 select pers).ToList();

            return ageCriteria;
        }

        public List<Person> FindPersonsInTown(List<Person> personList, string cityName)
        {
            List<Person> cityCriteria =
                (from pers in personList
                 where pers.Adress.ToUpper().Contains(cityName.ToUpper())
                 select pers).ToList();

            return cityCriteria;
        }

        public List<Person> FindPersonsOnSameAddress(List<Person> personList)
        {
            List<Person> sameAdressCriteria = new List<Person>();

            return sameAdressCriteria;
        }
    }

    public enum Gender
    {
        Senior,
        MiddleAge,
        Adult,
        Kid
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public Gender Gender { get; set; }
        public Person()
        {
        }

        public Person(string name, int age, string adress, Gender gender)
        {
            Name = name;
            Age = age;
            Adress = adress;
            Gender = gender;
        }
    }
}