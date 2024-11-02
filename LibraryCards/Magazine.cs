using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryCards
{
    //TODO: XML+
    /// <summary>
    /// Класс создания библ. карточки по стате из журнала.
    /// </summary>
    /// <returns>Объект класса Magazine.</returns>
    public class Magazine : CardBase
    {
        /// <summary>
        /// Название журнала.
        /// </summary>
        private string _nameOfMagazine;

        /// <summary>
        /// Номер журнала.
        /// </summary>
        private int _numberOfMagazine;

        /// <summary>
        /// Сведение об издании.
        /// </summary>
        private string _additionalInformation;

        //TODO: RSDN+
        /// <summary>
        /// Начальная страница.
        /// </summary>
        private int _startSheet;

        //TODO: RSDN+
        /// <summary>
        /// Последняя странца.
        /// </summary>
        private int _endSheet;

        /// <summary>
        /// Объект класс Magazine по умолчанию.
        /// </summary>
        /// //TODO: RSDN
        public Magazine() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 1, "Неизвестно", 1900, 0, 1)
        { }

        /// <summary>
        /// Конструктор класса Magazine.
        /// </summary>
        /// <param name="surname">Фамилия автора.</param>
        /// <param name="name">ФИО автора.</param>
        /// <param name="patronymic">ФИО автора.</param>
        /// <param name="title">Название работы.</param>
        /// <param name="nameOfMagazine">Название журнала.</param>
        /// <param name="numberOfMagazine">Номер журнала.</param>
        /// <param name="additionalInformation">Сведение об издании.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="startSheet">Начальная страница.</param>
        /// <param name="endSheet">Последняя страница.</param>
        /// TODO: цепочка конструкторов+
        public Magazine(string surname, string name, string patronymic, string title, string nameOfMagazine,
            int numberOfMagazine, string additionalInformation, int year, 
            int startSheet, int endSheet) : base(surname, name, patronymic, title, year)

        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Title = title;
            NameOfMagazine = nameOfMagazine;
            NumberOfMagazine = numberOfMagazine;
            AdditionalInformation = additionalInformation;
            Year = year;
            StartSheet = startSheet;
            EndSheet = endSheet;
        }

        /// <summary>
        /// Метод вывода библиотечной карточки.
        /// </summary>
        /// <returns>Данные об издании.</returns>
        public virtual string GetInfo()
        {
            /*return $"Имя: {Name}, Фамилия: {LastName}," +
                   $" Возраст: {Age}, Пол: {Gender}";*/
        }

        /// <summary>
        /// Метод добавления автора.
        /// </summary>
        /// <returns>Автора издания.</returns>
        public string AddAuthor()
        {
            /*return $"Имя: {Name}, Фамилия: {LastName}," +
                   $" Возраст: {Age}, Пол: {Gender}";*/
        }
    }
}
