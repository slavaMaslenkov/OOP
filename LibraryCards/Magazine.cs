using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        /// Регулярное выражение, выявляющее цифры.
        /// </summary>
        private const string _ageRegex = @"^\d+$";

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
        /// Название журнала.
        /// </summary>
        public string NameOfMagazine
        {
            get
            {
                return _nameOfMagazine;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "Введена пустая строка.");
                }
                else
                {
                    _nameOfMagazine = TitleSplitAndJoin(value);
                }
            }
        }

        /// <summary>
        /// Количество страниц.
        /// </summary>
        public int NumberOfMagazine
        {
            get => _numberOfMagazine;

            set
            {
                if (value > MaxSheet || value < MinSheet)
                {
                    throw new ArgumentException(
                        $"Введите число из диапазона от {MinSheet} до {MaxSheet}.");

                }
                else
                {
                    _numberOfMagazine = IsCorrectYear(value);
                }
            }
        }

        /// <summary>
        /// Сведение об издании.
        /// </summary>
        public string AdditionalInformation
        {
            get
            {
                return _additionalInformation;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "Введена пустая строка.");
                }
                else
                {
                    _additionalInformation = TitleSplitAndJoin(value);
                }
            }
        }

        /// <summary>
        /// Начальная страница.
        /// </summary>
        public int StartSheet
        {
            get => _startSheet;

            set
            {
                if (value > MaxSheet || value < MinSheet)
                {
                    throw new ArgumentException(
                        $"Введите число из диапазона от {MinSheet} до {MaxSheet}.");

                }
                else
                {
                    _startSheet = IsCorrectYear(value);
                }
            }
        }

        /// <summary>
        /// Последняя страница.
        /// </summary>
        public int EndSheet
        {
            get => _endSheet;

            set
            {
                if ( value? < StartSheet)
                {
                    throw new ArgumentException(
                        $"Введите число больше {StartSheet}.");

                }
                else if (value? == StartSheet)
                {
                    _endSheet = null;
                }
            }
        }

        /// <summary>
        /// Проверяет страницу на корректность./>.
        /// </summary>
        /// <param name="endSheet">Имя объекта.</param>
        /// <returns>Возраст/>.</returns>
        public static int IsCorrectSheet(int endSheet)
        {
            string stringAge = Convert.ToString(endSheet);
            if (Regex.IsMatch(stringAge, _ageRegex) && !string.IsNullOrEmpty(stringAge))
            {
                return Convert.ToInt16(stringAge);
            }
            else
            {
                throw new ArgumentException("Введите только число.");
            }
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

    }
}
