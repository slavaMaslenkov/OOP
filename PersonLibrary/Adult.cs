using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Adult() : this("Неизвестно", "Неизвестно", 18, Gender.Male, "0000","000000", null, null)
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
        /// Номер пасспорта.
        /// </summary>
        public string NumberOfPassport { get; set; }

        /// <summary>
        /// Серия пасспорта.
        /// </summary>
        public string SeriesOfPassport { get; set; }

        /// <summary>
        /// Партнер.
        /// </summary>
        public Adult Partner { get; set; }

        /// <summary>
        /// Работа.
        /// </summary>
        public string Job { get; set; }

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
