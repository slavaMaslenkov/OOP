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
    /// Класс создания библ. карточки по статье из сборника.
    /// </summary>
    /// <returns>Объект класса Book.</returns>
    public class Sbornik : CardBase
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
        /// НАчальная страница.
        /// </summary>
        private int _startSheet;

        /// <summary>
        /// Последняя странца.
        /// </summary>
        private string _endSheet;

        /// <summary>
        /// Регулярное выражение, выявляющее цифры.
        /// </summary>
        private const string _ageRegex = @"^\d+$";

        /// <summary>
        /// Объект класс Sbornik по умолчанию.
        /// </summary>
        public Sbornik() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 
            "Неизвестно", 1900, 1,null)
        { }

        /// <summary>
        /// Конструктор класса Sbornik.
        /// </summary>
        /// <param name="surname">Фамилия автора.</param>
        /// <param name="name">ФИО автора.</param>
        /// <param name="patronymic">ФИО автора.</param>
        /// <param name="title">Название работы.</param>
        /// <param name="placeOfPublication">Место публикации.</param>
        /// <param name="publishingHouse">Издательство.</param>
        /// <param name="nameOfSbornik">Название сборника.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="startSheet">Начальная страница.</param>
        /// <param name="endSheet">Последняя страница.</param>
        /// //TODO: RSDN
        public Sbornik(string surname, string name, string patronymic, string title, string nameOfSbornik,
            string placeOfPublication, string publishingHouse, 
            int year, int startSheet, string endSheet) : base(surname, name, patronymic, title, year)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Title = title;
            NameOfSbornik = nameOfSbornik;
            PlaceOfPublication = placeOfPublication;
            PublishingHouse = publishingHouse;
            Year = year;
            StartSheet = startSheet;
            EndSheet = endSheet;
        }

        /// <summary>
        /// Название сборника.
        /// </summary>
        public string NameOfSbornik
        {
            get
            {
                return _nameOfSbornik;
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
                    _nameOfSbornik = TitleSplitAndJoin(value);
                }
            }
        }

        /// <summary>
        /// Место издания.
        /// </summary>
        public string PlaceOfPublication
        {
            get
            {
                return _placeOfPublication;
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
                    _placeOfPublication = TitleSplitAndJoin(value);
                }
            }
        }

        /// <summary>
        /// Издательство.
        /// </summary>
        public string PublishingHouse
        {
            get
            {
                return _publishingHouse;
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
                    _publishingHouse = TitleSplitAndJoin(value);
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
        public string EndSheet
        {
            get => _endSheet;

            set
            {
                _endSheet = IsCorrectSheet(value);
            }
        }

        /// <summary>
        /// Проверяет страницу на корректность./>.
        /// </summary>
        /// <param name="endSheet">Имя объекта.</param>
        /// <returns>True or False/>.</returns>
        public string IsCorrectSheet(string endSheet)
        {
            if (endSheet == null)
            {
                return null;
            }
            else if (Regex.IsMatch(endSheet, _ageRegex))
            {
                int intEndSheet = Convert.ToInt16(endSheet);
                if (intEndSheet < StartSheet)
                {
                    throw new ArgumentException($"Введите число больше {StartSheet}.");
                }
                else if (intEndSheet == StartSheet)
                {
                    return null;
                }
                else
                {
                    return $"-{endSheet}";
                }
            }
            else
            {
                throw new ArgumentException($"Введите последнюю страницу.");
            }
        }

        /// <summary>
        /// Метод вывода библиотечной карточки.
        /// </summary>
        /// <returns>Данные об издании.</returns>
        public override string GetInfo()
        {
            return $"{MakeSample(Surname, Name, Patronymic)} {Title} /" +
                   $"{ReverseFullname(MakeSample(Surname, Name, Patronymic))}. " +
                   $"// {NameOfSbornik}. –{PlaceOfPublication}: - №{PublishingHouse}," +
                   $" {Year}. - С. {StartSheet}{EndSheet}.";
        }

    }
}
