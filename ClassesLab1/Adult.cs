using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab1
{
    internal class Adult : Person
    {
        /// <summary>
        /// Номер паспорта.
        /// </summary>
        private int _numberOfPassport;

        /// <summary>
        /// Серия паспорта.
        /// </summary>
        private int _seriesOfPassport;

        /// <summary>
        /// Состояние брака.
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Место работы.
        /// </summary>
        private string _job;

        /// <summary>
        /// Объект класса Adult по умолчанию.
        /// </summary>
        public Adult() : this("Неизвестно", "Неизвестно", 18, Gender.Male, 0000,000000, null, null)
        { }

        /// <summary>
        /// Конструктор класса Adult.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="numberOfPassport">Номер паспорта.</param>
        /// <param name="seriesOfPassport">Серия паспорта.</param>
        /// <param name="partner">Партнер по браку.</param>
        /// <param name="job">Место работы.</param>
        public Adult(string name, string surname, int age, Gender gender, int numberOfPassport,
            int seriesOfPassport, Adult partner, string job) : base(name, surname, age, gender)
        {
            NumberOfPassport = numberOfPassport;
            SeriesOfPassport = seriesOfPassport;
            Partner = partner;
            Job = job;
        }

        public int NumberOfPassport { get; set; }
        public int SeriesOfPassport { get; set; }

        public Adult Partner { get; set; }
        public string Job { get; set; }

        /// <summary>
        /// Создает рандомный объект класса Adult/>.
        /// </summary>
        /// <returns>Объект класса Adult/>.</returns>
        public static Adult GetRandomPerson()
        {
            Random rnd = new Random();
            string[] names = { "Катя", "Оля", "Наташа", "Света", "Галя",
                "Слава", "Эдик", "Вова", "Даня", "Коля" };
            string[] surnames = { "Катяшкина", "Олечкина", "Наташечкина",
                "Светова", "Галова", "Славин", "Эдиксон", "Вовчанин", "Данон", "Коликов" };

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
