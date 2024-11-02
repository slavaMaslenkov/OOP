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
    /// Класс создания библ. карточки по книге.
    /// </summary>
    /// <returns>Объект класса Book.</returns>
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
        /// Объект класс Book по умолчанию.
        /// </summary>
        /// //TODO: RSDN+
        public Book() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 
            "Неизвестно", 1900, 100)
        { }

        /// <summary>
        /// Конструктор класса Book.
        /// </summary>
        /// <param name="surname">Фамилия автора.</param>
        /// <param name="name">ФИО автора.</param>
        /// <param name="patronymic">ФИО автора.</param>
        /// <param name="title">Название работы.</param>
        /// <param name="placeOfPublication">Место издания.</param>
        /// <param name="publishingHouse">Издательство.</param>
        /// <param name="additionalInformation">Сведение об издании.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="sheet">Количество страниц.</param>
        /// TODO: цепочка конструкторов+
        public Book(string surname, string name, string patronymic, string title, string placeOfPublication, 
            string publishingHouse, string additionalInformation, 
            int year, int sheet) : base(surname, name, patronymic, title, year)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Title = title;
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
