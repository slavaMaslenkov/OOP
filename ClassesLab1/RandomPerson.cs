using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    /// <summary>
    /// Создание объекта класса RandomPerson.
    /// </summary>
    /// <returns>ОБъект класса Person .</returns>
    public static class RandomPerson
    {
        /// <summary>
        /// Создает рандомный объект класса Adult.
        /// </summary>
        /// <returns>Объект класса Child .</returns>
        public static Adult GetRandomAdult()
        {
            Adult person1 = new Adult();
            Random rnd = new Random();
            Gender gender = (Gender)rnd.Next(Enum.GetNames(typeof(Gender)).Length);
            GetPerson(gender, person1);
            GetAdultInfo(person1);
            GetPartner(gender, person1);

            return person1;
        }

        /// <summary>
        /// Получаем характеристику персоны.
        /// <summary>
        /// <param name="gender">Имя объекта.</param>
        /// <param name="person">Имя объекта.</param>
        /// </summary>
        public static void GetPerson(Gender gender, Person person)
        {
            Random rnd = new Random();
            //TODO: RSDN
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
            person.Age = rnd.Next(person.MinAge, person.MaxAge);
        }

        /// <summary>
        /// Получаем характеристику взрослого.
        /// <summary>
        /// <param name="person">Имя объекта.</param>
        public static void GetAdultInfo(Adult person)
        {
            Random rnd = new Random();
            int work_status = rnd.Next(2);
            if (work_status == 1)
            {
                string[] work = { "50Ohm", "Open AI", "ХК Сибирь", "Microsoft", "Binance" };
                person.Job = work[rnd.Next(work.Length - 1)];
            }
            else
            {
                person.Job = "Безработный";
            }

            person.NumberOfPassport = rnd.Next(0, 1000000).ToString("D6");
            person.SeriesOfPassport = rnd.Next(0, 10000).ToString("D4");
        }

        /// <summary>
        /// Получаем характеристику персоны.
        /// </summary>
        /// <param name="gender">Пол объекта.</param>
        /// <param name="person">Имя объекта.</param>
        public static void GetPartner(Gender gender, Adult person)
        {
            Random rnd = new Random();
            //TODO: RSDN
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

        /// <summary>
        /// Создает рандомный объект класса Child.
        /// </summary>
        /// <returns>Объект класса Child .</returns>
        public static Child GetRandomChild()
        {
            //TODO: RSDN
            Child person1 = new Child();
            Random rnd = new Random();
            Gender gender = (Gender)rnd.Next(Enum.GetNames(typeof(Gender)).Length);

            GetPerson(gender, person1);
            GetChildInfo(person1);
            GetParent(person1);

            switch (gender)
            {
                case Gender.Female:
                    if (person1.ParentM != null)
                    {
                        person1.Surname = person1.ParentM.Surname + "а";
                    }
                    else if (person1.ParentM == null && person1.ParentF != null)
                    {
                        person1.Surname = person1.ParentF.Surname;
                    }
                    break;
                case Gender.Male:
                    if (person1.ParentM != null)
                    {
                        person1.Surname = person1.ParentM.Surname;
                    }
                    else if (person1.ParentM == null && person1.ParentF != null)
                    {
                        person1.Surname = person1.ParentF.Surname[..^1];
                    }
                    break;
            }
            return person1;
        }

        /// <summary>
        /// Получаем характеристику ребенка.
        /// </summary>
        /// <param name="person">Имя объекта.</param>
        public static void GetChildInfo(Child person)
        {
            if (person.Age < 7)
            {
                Random rnd = new Random();
                string[] kindergarten = { "ДС Русалка", "ДС Дельфин", "ДС Карась", "ДС Солнышко" };
                person.Kindergarten = kindergarten[rnd.Next(kindergarten.Length - 1)];
            }
            else
            {
                Random rnd = new Random();
                string[] kindergarten = { "Гимназия", "Лицей", "Школа №25", "Школа №5" };
                person.Kindergarten = kindergarten[rnd.Next(kindergarten.Length - 1)];
            }
        }

        /// <summary>
        /// Получаем родителей ребенка.
        /// </summary>
        /// <param name="person">Имя объекта.</param>
        public static void GetParent(Child person)
        {
            Random rnd = new Random();
            int number_parents = rnd.Next(3);
            if (number_parents == 1)
            {
                person.ParentF = null;
                person.ParentM = null;
            }
            else if (number_parents == 2)
            {
                Gender gender = (Gender)rnd.Next(Enum.GetNames(typeof(Gender)).Length);
                Adult person2 = new Adult();
                GetPerson(gender, person2);
                GetAdultInfo(person2);
                person2.Partner = null;
                if (gender == Gender.Male)
                {
                    person.ParentM = person2;
                    person.ParentF = null;
                }
                else
                {
                    person.ParentF = person2;
                    person.ParentM = null;
                }

            }
            else
            {
                Adult person1 = new Adult();
                GetPerson(Gender.Male, person1);
                GetAdultInfo(person1);
                Adult person2 = new Adult();
                GetPerson(Gender.Female, person2);
                GetAdultInfo(person2);
                person1.Partner = person2;
                person2.Partner = person1;
                person2.Surname = person1.Surname + "а";

                person.ParentF = person2;
                person.ParentM = person1;
            }
        }
    }
}
