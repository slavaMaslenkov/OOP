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
    /// Класс создания библ. карточки по статье из сборника.
    /// </summary>
    /// <returns>Объект класса Book.</returns>
    internal class Sbornik : CardBase
    {
        /// <summary>
        /// Название сборника.
        /// </summary>
        private string _nameOfSbornik;

        /// <summary>
        /// Издательство.
        /// </summary>
        private string _publishingHouse;

        /// <summary>
        /// Место издания.
        /// </summary>
        private string _placeOfPublication;

        /// <summary>
        /// Сведение об издании.
        /// </summary>
        private string _additionalInformation;

        /// <summary>
        /// НАчальная страница.
        /// </summary>
        private int _startSheet;

        /// <summary>
        /// Последняя странца.
        /// </summary>
        private int _endSheet;

        /// <summary>
        /// Объект класс Sbornik по умолчанию.
        /// </summary>
        public Sbornik() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 
            "Неизвестно", "Неизвестно", 1900, 0,1)
        { }

        /// <summary>
        /// Конструктор класса Sbornik.
        /// </summary>
        /// <param name="fullName">Фамилия И.О. автора.</param>
        /// <param name="name">Название работы.</param>
        /// <param name="placeOfPublication">Место публикации.</param>
        /// <param name="publishingHouse">Издательство.</param>
        /// <param name="nameOfSbornik">Название сборника.</param>
        /// <param name="additionalInformation">Дополнительная информация.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="startSheet">Начальная страница.</param>
        /// <param name="endSheet">Последняя страница.</param>
        /// TODO: цепочка конструкторов+
        public Sbornik(string fullName, string name, string nameOfSbornik,
            string placeOfPublication, string publishingHouse, string additionalInformation, 
            int year, int startSheet, int endSheet) : base(fullName, name, year)
        {
            Fullname = fullName;
            Name = name;
            NameOfSbornik = nameOfSbornik;
            PlaceOfPublication = placeOfPublication;
            PublishingHouse = publishingHouse;
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
