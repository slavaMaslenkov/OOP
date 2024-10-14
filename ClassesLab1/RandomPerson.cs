using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab1
{
    internal class RandomPerson
    {
        
        /// <summary>
        /// Создает рандомный объект класса Adult.
        /// </summary>
        /// <returns>ОБъект класса Person .</returns>
        public static Adult GetRandomAdult()
        {
            Adult person1 = new Adult();
            Random rnd = new Random();
            Gender gender = (Gender)rnd.Next(Enum.GetNames(typeof(Gender)).Length);
            GetPerson(gender, person1);

            
            
            string[] names = { "Катя", "Оля", "Наташа", "Света", "Галя",
                "Слава", "Эдик", "Вова", "Даня", "Коля" };
            string[] surnames = { "Катяшкина", "Олечкина", "Наташечкина",
                "Светова", "Галова", "Славин", "Эдиксон", "Вовчанин", "Данон", "Коликов" };

            int namesIndex = rnd.Next(names.Length - 1);


        }

        /// <summary>
        /// Получаем характеристику персоны.
        /// </summary>
        public static void GetPerson(Gender gender, Person person)
        {
            Random rnd = new Random();
            string[] namesM = { "Некит", "Юра", "Вася", "Растик", "Приус",
                "Слава", "Эдик", "Вова", "Даня", "Коля" };
            string[] namesF = { "Катя", "Оля", "Наташа", "Света", "Галя",
                "Изабелла", "Жанна", "Снежанна", "Коляска", "Юлька" };
            string[] surnames = { "Катяшкин", "Олечкин", "Наташечкин",
                "Светов", "Галов", "Славин", "Эдиксон", "Вовчанин", "Данон", "Коликов" };
            
            if (gender == Gender.Male)
            {
                person.Name = namesM[rnd.Next(namesM.Length - 1)];
                person.Surname = surnames[rnd.Next(surnames.Length - 1)];
            }
            else
            {
                person.Name = namesF[rnd.Next(namesF.Length - 1)];
                person.Surname = surnames[rnd.Next(surnames.Length - 1)] + 'а';
            }

            person.Gender = gender;
            person.Age = rnd.Next(Person._minAge, Person._maxAge);
        }

    }
}
