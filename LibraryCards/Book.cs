using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryCards
{
    public class Book : CardBase
    {
        /// <summary>
        /// Место издания.
        /// </summary>
        private string _placeOfPublication;

        /// <summary>
        /// Издательство.
        /// </summary>
        private string _publishingHouse;

        /// <summary>
        /// Сведение об издании.
        /// </summary>
        private string _additionalInformation;

        /// <summary>
        /// Количество страниц.
        /// </summary>
        private int _sheet;

        /// <summary>
        /// Объект класс CardBase по умолчанию.
        /// </summary>
        public Book() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 1900, 100)
        { }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="fullName">Имя.</param>
        /// <param name="name">Фамилия.</param>
        /// <param name="placeOfPublication">Имя.</param>
        /// <param name="publishingHouse">Фамилия.</param>
        /// <param name="additionalInformation">Возраст.</param>
        /// <param name="year">Возраст.</param>
        /// <param name="sheet">Пол.</param>
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
