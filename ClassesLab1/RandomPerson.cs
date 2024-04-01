using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab1
{
    public class RandomPerson
    {
        Random rnd = new Random();
        string[] names = { "Катя", "Оля", "Наташа", "Света", "Галя" , "Слава", "Эдик", "Вова", "Даня", "Коля" };
        string[] surnames = { "Катяшкина", "Олечкина", "Наташечкина", "Светова", "Галова", "Славин", "Эдиксон", "Вовчанин", "Данон", "Коликов" };
        


        public Person GetRandomPerson()
        {
            int namesIndex = rnd.Next(names.Length - 1);
            
            Person randomPerson = new Person();
            randomPerson.Age = rnd.Next(Person._minAge, Person._maxAge);

            if (namesIndex < names.Length * 0.5)
            {
                randomPerson.Name = names[namesIndex];
                randomPerson.Surname = surnames[namesIndex];
                randomPerson.Gender = Gender.Female;
            }
            else
            {
                randomPerson.Name = names[namesIndex];
                randomPerson.Surname = surnames[namesIndex];
                randomPerson.Gender = Gender.Male;
            }

            return randomPerson;
        }
           

    }
}
