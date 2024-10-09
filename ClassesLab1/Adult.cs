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
        private string _numberOfPassport;

        /// <summary>
        /// Серия паспорта.
        /// </summary>
        private string _seriesOfPassport;

        /// <summary>
        /// Объект класса Adult по умолчанию.
        /// </summary>
        public Adult() : this("Неизвестно", "Неизвестно", 18, Gender.Male, "0000","000000", "Холост")
        { }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
    }
}
