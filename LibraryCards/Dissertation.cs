using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private int _specialtyCode;

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
        /// Объект класс Dissertation по умолчанию.
        /// </summary>
        /// //TODO: RSDN+
        public Dissertation() : this("Неизвестно", "Неизвестно", "Неизвестно", "Неизвестно",
            "Неизвестно", "Неизвестно", "Неизвестно", 1900, 100)
        { }

        /// <summary>
        /// Конструктор класса Dissertation.
        /// </summary>
        /// <param name="fullName">ФИО автора.</param>
        /// <param name="name">Название работы.</param>
        /// <param name="kindOfDissert">Вид диссертации.</param>
        /// <param name="branchOfScience">Отрасль наук.</param>
        /// <param name="specialtyCode">Код специальности.</param>
        /// <param name="organization">Организация, где проходила защита.</param>
        /// <param name="nameOfSpeciality">Название специальности.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="sheet">Количество страниц.</param>
        public Dissertation(string fullName, string name, string kindOfDissert,
            string branchOfScience, int specialtyCode, string organization,
            string nameOfSpeciality, int year, int sheet) : base(fullName, name, year)
        {
            Fullname = fullName;
            Name = name;
            KindOfDissert = kindOfDissert;
            BranchOfScience = branchOfScience;
            SpecialtyCode = specialtyCode;
            Organization = organization;
            NameOfSpeciality = nameOfSpeciality;
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
