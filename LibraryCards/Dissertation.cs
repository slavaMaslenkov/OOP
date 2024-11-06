using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryCards
{
    /// <summary>
    /// Класс создания библ. карточки по диссертации.
    /// </summary>
    /// <returns>Объект класса Book.</returns>
    public class Dissertation : CardBase
    {
        /// <summary>
        /// Вид диссертации.
        /// </summary>
        private string _kindOfDissert;

        /// <summary>
        /// Отрасль наук.
        /// </summary>
        private string _branchOfScience;

        /// <summary>
        /// Код специальности.
        /// </summary>
        private string _specialtyCode;

        /// <summary>
        /// Организация, где проходила защита.
        /// </summary>
        private string _organization;

        /// <summary>
        /// Название специальности.
        /// </summary>
        private string _nameOfSpeciality;

        /// <summary>
        /// Количество страниц.
        /// </summary>
        private int _sheet;

        /// <summary>
        /// Регулярное выражение, определяющее код.
        /// </summary>
        private const string _codeRegex = @"^\d{2}\.\d{2}\.\d{2}$";

        /// <summary>
        /// Объект класс Dissertation по умолчанию.
        /// </summary>
        /// //TODO: RSDN+
        public Dissertation() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 
            "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно", 1900, 100)
        { }

        /// <summary>
        /// Конструктор класса Dissertation.
        /// </summary>
        /// <param name="surname">Фамилия автора.</param>
        /// <param name="name">ФИО автора.</param>
        /// <param name="patronymic">ФИО автора.</param>
        /// <param name="title">Название работы.</param>
        /// <param name="kindOfDissert">Вид диссертации.</param>
        /// <param name="branchOfScience">Отрасль наук.</param>
        /// <param name="specialtyCode">Код специальности.</param>
        /// <param name="organization">Организация, где проходила защита.</param>
        /// <param name="nameOfSpeciality">Название специальности.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="sheet">Количество страниц.</param>
        public Dissertation(string surname, string name, string patronymic, string title, string kindOfDissert,
            string branchOfScience, string specialtyCode, string organization,
            string nameOfSpeciality, int year, int sheet) : base(surname, name, patronymic, title, year)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Title = title;
            KindOfDissert = kindOfDissert;
            BranchOfScience = branchOfScience;
            SpecialtyCode = specialtyCode;
            Organization = organization;
            NameOfSpeciality = nameOfSpeciality;
            Year = year;
            Sheet = sheet;
        }

        /// <summary>
        /// Количество страниц.
        /// </summary>
        public int Sheet
        {
            get => _sheet;

            set
            {
                if (value > MaxSheet || value < MinSheet)
                {
                    throw new ArgumentException(
                        $"Введите число из диапазона от {MinSheet} до {MaxSheet}.");

                }
                else
                {
                    _sheet = IsCorrectYear(value);
                }
            }
        }

        /// <summary>
        /// Количество страниц.
        /// </summary>
        public string SpecialtyCode
        {
            get => _specialtyCode;

            set
            {
                if (Regex.IsMatch(value, _codeRegex))
                {
                    _specialtyCode = value;
                }
                else
                {
                    throw new ArgumentException(
                        $"Введите код в формате __.__.__ .");
                }
            }
        }

        /// <summary>
        /// Вид диссертации.
        /// </summary>
        public string KindOfDissert
        {
            get
            {
                return _kindOfDissert;
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
                    _kindOfDissert = TitleSplitAndJoin(value);
                }
            }
        }

        /// <summary>
        /// Отрасль наук.
        /// </summary>
        public string BranchOfScience
        {
            get
            {
                return _branchOfScience;
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
                    _branchOfScience = TitleSplitAndJoin(value);
                }
            }
        }

        /// <summary>
        /// Организация.
        /// </summary>
        public string Organization
        {
            get
            {
                return _organization;
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
                    _organization = TitleSplitAndJoin(value);
                }
            }
        }

        /// <summary>
        /// Отрасль наук.
        /// </summary>
        public string NameOfSpeciality
        {
            get
            {
                return _nameOfSpeciality;
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
                    _nameOfSpeciality = TitleSplitAndJoin(value);
                }
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
