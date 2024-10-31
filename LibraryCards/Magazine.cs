using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryCards
{
    //TODO: XML
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

        //TODO: RSDN
        /// <summary>
        /// Начальная страница.
        /// </summary>
        private int StartSheet;

        //TODO: RSDN
        /// <summary>
        /// Последняя странца.
        /// </summary>
        private int EndSheet;

        /// <summary>
        /// Объект класс CardBase по умолчанию.
        /// </summary>
        /// //TODO: RSDN
        public Magazine() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 1900, 0, 1)
        { }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="fullName">Имя.</param>
        /// <param name="name">Фамилия.</param>
        /// <param name="placeOfPublication">Имя.</param>
        /// <param name="publishingHouse">Фамилия.</param>
        /// <param name="additionalInformation">Возраст.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="startSheet">Начальная страница.</param>
        /// <param name="endSheet">Последняя страница.</param>
        /// TODO: цепочка конструкторов
        public Magazine(string fullName, string name, string placeOfPublication,
            string publishingHouse, string additionalInformation, int year, int startSheet, int endSheet)

        {
            Fullname = fullName;
            Name = name;
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
