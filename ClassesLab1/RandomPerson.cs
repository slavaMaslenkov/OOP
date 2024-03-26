using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab1
{
    internal class RandomPerson
    {
        Random rnd = new Random();
        string[] names = { "Катя", "Оля", "Наташа", "Света", "Галя" , "Слава", "Эдик", "Вова", "Даня", "Коля" };
        string[] surnames = { "Катяшкина", "Олечкина", "Наташечкина", "Светова", "Галова", "Славин", "Эдиксон", "Вовчанин", "Данон", "Коликов" };
        int[] age = {23, 17, 51, 22, 89};


        public Person GetRandomPerson()
        {
            int namesIndex = rnd.Next(names.Length);

            Person randomPerson = new Person();

            if (namesIndex < names.Length * 0.5)
            {
                randomPerson.Name = names[namesIndex];
                randomPerson.Surname = surnames[namesIndex];
                randomPerson.Age = age[namesIndex];
                randomPerson.Gender = Gender.Female;
            }
            else
            {
                randomPerson.Name = names[namesIndex];
                randomPerson.Surname = surnames[namesIndex];
                randomPerson.Age = age[namesIndex];
                randomPerson.Gender = Gender.Male;
            }

            return randomPerson;
        }
           

    }
}
