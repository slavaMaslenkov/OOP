using System.Reflection;
using System.Xml.Linq;

namespace LibraryCards
{
    /// <summary>
    /// Базовый класс создания библиотечной карточки.
    /// </summary>
    /// <returns>Объект класса CardBase.</returns>
    public abstract class CardBase
    {
        /// <summary>
        /// Фамилия И.О. автора.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Название.
        /// </summary>
        private string _name;

        /// <summary>
        /// Регулярное выражение, выявляющее русские буквы.
        /// </summary>
        private const string _russianRegex = @"(^[а-яА-Я]+(-[а-яА-Я]+)*$)";

        /// <summary>
        /// Регулярное выражение, выявляющее английские буквы.
        /// </summary>
        private const string _ageRegex = @"^\d+$";


        /// <summary>
        /// Год издания.
        /// </summary>
        private int _year;

        /// <summary>
        /// Минимальный год издания.
        /// </summary>
        public int MinYear { get; } = 1800;

        /// <summary>
        /// Масимальный год издания.
        /// </summary>
        public int MaxYear { get; } = 2024;

        /// <summary>
        /// Минимальное количество страниц.
        /// </summary>
        public int MinSheet { get; } = 1;

        /// <summary>
        /// Масимальное количество страниц.
        /// </summary>
        public int MaxSheet { get; } = 5000;

        /// <summary>
        /// Объект класс CardBase по умолчанию.
        /// </summary>
        public CardBase() : this("Неизвестно", "Неизвестно", 1900)
        { }

        /// <summary>
        /// Конструктор класса CardBase.
        /// </summary>
        /// <param name="fullName">ФИО автора.</param>
        /// <param name="name">Название работы.</param>
        /// <param name="year">Возраст.</param>
        public CardBase(string fullName, string name, int year)
        {
            Fullname = fullName;
            Name = name;
            Year = year;
        }

        /// <summary>
        /// Метод изменения порядка ФИО в ИОФ.
        /// </summary>
        /// <returns>Данные об издании.</returns>
        public virtual string ReverseFullname(string fullName)
        {
            string[] parts = fullName.Split(' ');
            string reverseFullname = parts[1] +" "+ parts[0];

            return reverseFullname;

        }

        /// <summary>
        /// Метод вывода библиотечной карточки.
        /// </summary>
        /// <returns>Данные об издании.</returns>
        public virtual string GetInfo()
        {
            return $"{Fullname} {Name}/" +
                   $"{ReverseFullname(Fullname)}.— {Year}.";
        }
    }
}
