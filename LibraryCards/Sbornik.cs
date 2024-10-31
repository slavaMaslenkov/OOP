using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryCards
{
    internal class Sbornik
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

        //// <summary>
        /// НАчальная страница.
        /// </summary>
        private int StartSheet;

        /// <summary>
        /// Последняя странца.
        /// </summary>
        private int EndSheet;

        /// <summary>
        /// Объект класс CardBase по умолчанию.
        /// </summary>
        public Sbornik() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 
            "Неизвестно", "Неизвестно", 1900, 0,1)
        { }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="fullName">Фамилия И.О. автора.</param>
        /// <param name="name">Фамилия.</param>
        /// <param name="placeOfPublication">Место публикации.</param>
        /// <param name="publishingHouse">Издательство.</param>
        /// <param name="nameOfSbornik">Название сборника.</param>
        /// <param name="additionalInformation">Дополнительная информация.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="startSheet">Начальная страница.</param>
        /// <param name="endSheet">Последняя страница.</param>
        public Book(string fullName, string name, string placeOfPublication,
            string publishingHouse, string additionalInformation, int year, int sheet)
        {
            Fullname = fullName;
            Name = name;
            PlaceOfPublication = placeOfPublication;
            PublishingHouse = publishingHouse;
            AdditionalInformation = additionalInformation;
            Year = year;
            Sheet = sheet;
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
