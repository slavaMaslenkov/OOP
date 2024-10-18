using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonLibrary
{
    //TODO: XML+
    /// <summary>
    /// Класс взрослый человек.
    /// </summary>
    public class Adult : PersonBase
    {
        //TODO: not using
        /// <summary>
        /// Номер паспорта.
        /// </summary>
        private string _numberOfPassport;

        //TODO: not using
        /// <summary>
        /// Серия паспорта.
        /// </summary>
        private string _seriesOfPassport;

        //TODO: not using
        /// <summary>
        /// Состояние брака.
        /// </summary>
        private Adult _partner;

        //TODO: not using
        /// <summary>
        /// Место работы.
        /// </summary>
        private string _job;

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public override int MinAge { get; } = 18;

        /// <summary>
        /// Масимальный возраст.
        /// </summary>
        public override int MaxAge { get; } = 120;

        /// <summary>
        /// Объект класса Adult по умолчанию.
        /// </summary>
        public Adult() : this("Неизвестно", "Неизвестно", 18, Gender.Male, "000000","0000", null, null)
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
        public Adult(string name, string surname, int age, Gender gender, string numberOfPassport,
            string seriesOfPassport, Adult partner, string job) : base(name, surname, age, gender)
        {
            NumberOfPassport = numberOfPassport;
            SeriesOfPassport = seriesOfPassport;
            Partner = partner;
            Job = job;
        }

        //TODO: validation
        /// <summary>
        /// Gets or sets номер пасспорта.
        /// </summary>
        public string NumberOfPassport
        {
            get
            {
                return _numberOfPassport;
            }
            set
            {
                if (value.ToString().Length == 6)
                {
                    _numberOfPassport = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Введите шестизначное число.");
                }
            }
        }

        /// <summary>
        /// Gets or sets серия пасспорта.
        /// </summary>
        public string SeriesOfPassport
        {
            get
            {
                return _seriesOfPassport;
            }
            set
            {
                if (value.ToString().Length == 4)
                {
                    _seriesOfPassport = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Введите четырехзначное число.");
                }
            }
        }

        /// <summary>
        /// Gets or sets партнер.
        /// </summary>
        public Adult Partner
        {
            get
            {
                return _partner;
            }
            set
            {
                if (value?.Gender == Gender)
                {
                    throw new ArgumentException(
                        "Однополые браки нельзя.");
                }

                if (value is not null)
                {
                    _partner = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets работа.
        /// </summary>
        public string Job
        {
            get
            {
                return _job;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    value = "Безработный";
                }
                else
                {
                     _job = value;
                }
            }
        }

        /// <summary>
        /// Возвращает строку с информацией об объекте.
        /// </summary>
        /// <returns>Информация об объекте.</returns>
        public override string GetInfo()
        {
            string info;
            if (Partner == null)
            {
                info = "Нет партнера";
            }
            else
            {
               info = Partner.Name + " " + Partner.Surname;
            }

            return $"Имя: {Name}\tФамилия: {Surname}" +
                    $"\tВозраст: {Age}\tПол: {Gender}" +
                    $"\tНомер паспорта: {NumberOfPassport}"+
                    $"\tСерия паспорта: {SeriesOfPassport}\tПартнер: {info}"+
                    $"\tМесто работы: {Job}\n";
        }

        /// <summary>
        /// Возвращает строку с информацией об объекте.
        /// </summary>
        /// <returns>Информация об объекте.</returns>
        public string AreYouAdult()
        {
            return $"Я взрослый.";
        }
    }
}
