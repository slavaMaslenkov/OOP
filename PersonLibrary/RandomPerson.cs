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
            Adult adult = new Adult();
            Random random = new Random();
            Gender gender = (Gender)random.Next(Enum.GetNames(typeof(Gender)).Length);
            GetPerson(gender, adult);
            GetAdultInfo(adult);
            GetPartner(gender, adult);

            return adult;
        }

        /// <summary>
        /// Получаем характеристику персоны.
        /// <summary>
        /// <param name="gender">Имя объекта.</param>
        /// <param name="adult">Имя объекта.</param>
        /// </summary>
        public static void GetPerson(Gender gender, PersonBase adult)
        {
            Random random = new Random();
            //TODO: RSDN+
            string[] namesMale = { "Некит", "Юра", "Вася", "Растик", "Руслан",
                "Слава", "Эдик", "Вова", "Даня", "Коля" };
            string[] namesFemale = { "Катя", "Оля", "Наташа", "Света", "Галя",
                "Изабелла", "Жанна", "Снежанна", "Ира", "Юля" };
            string[] surnames = { "Катяшкин", "Олечкин", "Наташечкин",
                "Светов", "Галов", "Славин", "Эдиксон", "Вовчанин", "Данон", "Коликов" };
            
            if (gender == Gender.Male)
            {
                adult.Name = namesMale[random.Next(namesMale.Length - 1)];
                adult.Surname = surnames[random.Next(surnames.Length - 1)];
            }
            else
            {
                adult.Name = namesFemale[random.Next(namesFemale.Length - 1)];
                adult.Surname = surnames[random.Next(surnames.Length - 1)] + 'а';
            }

            adult.Gender = gender;
            adult.Age = random.Next(adult.MinAge, adult.MaxAge);
        }

        /// <summary>
        /// Получаем характеристику взрослого.
        /// <summary>
        /// <param name="adult">Имя объекта.</param>
        public static void GetAdultInfo(Adult adult)
        {
            Random random = new Random();
            int workStatus = random.Next(2);
            if (workStatus == 1)
            {
                string[] work = { "50Ohm", "Open AI", "ХК Сибирь", "Microsoft", "Binance" };
                adult.Job = work[random.Next(work.Length - 1)];
            }
            else
            {
                adult.Job = "Безработный";
            }

            adult.NumberOfPassport = random.Next(0, 1000000).ToString("D6");
            adult.SeriesOfPassport = random.Next(0, 10000).ToString("D4");
        }

        /// <summary>
        /// Получаем характеристику персоны.
        /// </summary>
        /// <param name="gender">Пол объекта.</param>
        /// <param name="adult">Имя объекта.</param>
        public static void GetPartner(Gender gender, Adult adult)
        {
            Random random = new Random();
            //TODO: RSDN+
            int maritalStatus = random.Next(2);
            if (maritalStatus == 1)
            {
                if (gender == Gender.Male)
                {
                    Adult person2 = new Adult();
                    GetPerson(Gender.Female, person2);
                    GetAdultInfo(person2);
                    adult.Partner = person2;
                    person2.Partner = adult;
                    person2.Surname = adult.Surname + "а";
                }
                else
                {
                    Adult person2 = new Adult();
                    GetPerson(Gender.Male, person2);
                    GetAdultInfo(person2);
                    adult.Partner = person2;
                    person2.Partner = adult;
                    adult.Surname = person2.Surname + "а";
                }
            }
            else
            {
                adult.Partner = null;
            }
        }

        /// <summary>
        /// Создает рандомный объект класса Child.
        /// </summary>
        /// <returns>Объект класса Child .</returns>
        public static Child GetRandomChild()
        {
            //TODO: RSDN+
            Child child = new Child();
            Random random = new Random();
            Gender gender = (Gender)random.Next(Enum.GetNames(typeof(Gender)).Length);

            GetPerson(gender, child);
            GetChildInfo(child);
            GetParent(child);

            switch (gender)
            {
                case Gender.Female:
                    if (child.Father != null)
                    {
                        child.Surname = child.Father.Surname + "а";
                    }
                    else if (child.Father == null && child.Mother != null)
                    {
                        child.Surname = child.Mother.Surname;
                    }
                    break;
                case Gender.Male:
                    if (child.Father != null)
                    {
                        child.Surname = child.Father.Surname;
                    }
                    else if (child.Father == null && child.Mother != null)
                    {
                        child.Surname = child.Mother.Surname[..^1];
                    }
                    break;
            }
            return child;
        }

        /// <summary>
        /// Получаем характеристику ребенка.
        /// </summary>
        /// <param name="child">Имя объекта.</param>
        public static void GetChildInfo(Child child)
        {
            Random random = new Random();
            if (child.Age < 7)
            {
                string[] educationalInstitution = { "ДС Русалка", "ДС Дельфин", "ДС Карась", "ДС Солнышко" };
                child.EducationalInstitution = educationalInstitution[random.Next(educationalInstitution.Length - 1)];
            }
            else
            {
                string[] educationalInstitution = { "Гимназия", "Лицей", "Школа №25", "Школа №5" };
                child.EducationalInstitution = educationalInstitution[random.Next(educationalInstitution.Length - 1)];
            }
        }

        /// <summary>
        /// Получаем родителей ребенка.
        /// </summary>
        /// <param name="child">Имя объекта.</param>
        public static void GetParent(Child child)
        {
            Random random = new Random();
            int numberParents = random.Next(3);
            if (numberParents == 1)
            {
                child.Mother = null;
                child.Father = null;
            }
            else if (numberParents == 2)
            {
                Gender gender = (Gender)random.Next(Enum.GetNames(typeof(Gender)).Length);
                Adult adult = new Adult();
                GetPerson(gender, adult);
                GetAdultInfo(adult);
                adult.Partner = null;
                if (gender == Gender.Male)
                {
                    child.Father = adult;
                    child.Mother = null;
                }
                else
                {
                    child.Mother = adult;
                    child.Father = null;
                }

            }
            else
            {
                Adult adult = new Adult();
                GetPerson(Gender.Male, adult);
                GetAdultInfo(adult);
                Adult adultPartner = new Adult();
                GetPerson(Gender.Female, adultPartner);
                GetAdultInfo(adultPartner);
                adult.Partner = adultPartner;
                adultPartner.Partner = adult;
                adultPartner.Surname = adult.Surname + "а";

                child.Mother = adultPartner;
                child.Father = adult;
            }
        }
    }
}
