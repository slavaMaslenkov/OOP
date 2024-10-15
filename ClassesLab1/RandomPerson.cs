using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab1
{
    /// <summary>
    /// Создание объекта класса RandomPerson.
    /// </summary>
    /// <returns>ОБъект класса Person .</returns>
    public class RandomPerson
    {
        
        /// <summary>
        /// Создает рандомный объект класса Adult.
        /// </summary>
        /// <returns>ОБъект класса Person .</returns>
        public static Adult GetRandomAdult(Adult person1)
        {;
            Random rnd = new Random();
            Gender gender = (Gender)rnd.Next(Enum.GetNames(typeof(Gender)).Length);
            GetPerson(gender, person1);
            GetAdultInfo(person1);
            GetPartner(gender,person1);

            return person1;

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

        /// <summary>
        /// Получаем характеристику взрослого.
        /// </summary>
        public static void GetAdultInfo(Adult person)
        {
            Random rnd = new Random();
            string[] work = { "50Ohm", "Open AI", "ХК Сибирь", "Microsoft", "Binance" }; 
            person.Job = work[rnd.Next(work.Length - 1)]; ;

            person.NumberOfPassport = rnd.Next(0,1000000).ToString("D6");
            person.SeriesOfPassport = rnd.Next(0, 10000).ToString("D4");
        }

        /// <summary>
        /// Получаем характеристику персоны.
        /// </summary>
        /// <returns>Взрослого человека</returns>
        public static void GetPartner(Gender gender, Adult person)
        {
            Random rnd = new Random();
            int marital_status = rnd.Next(2);
            if (marital_status == 1)
            {
                if (gender == Gender.Male)
                {
                    Adult person2 = new Adult();
                    GetPerson(Gender.Female, person2);
                    GetAdultInfo(person2);
                    person.Partner = person2;
                    person2.Partner = person;
                    person2.Surname = person.Surname + "а";
                }
                else
                {
                    Adult person2 = new Adult();
                    GetPerson(Gender.Male, person2);
                    GetAdultInfo(person2);
                    person.Partner = person2;
                    person2.Partner = person;
                    person.Surname = person2.Surname + "а";
                }
            }
            else
            {
                person.Partner = null;
            }
        }
            
    }
}
