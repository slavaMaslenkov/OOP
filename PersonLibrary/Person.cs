using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PersonLibrary
{
    //TODO: RSDN?+
    /// <summary>
    /// Класс Person, содержащий: имя, фамилию, возраст, пол.
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Регулярное выражение, выявляющее русские буквы.
        /// </summary>
        private const string _russianRegex = @"(^[а-яА-Я]+(-[а-яА-Я]+)*$)";

        /// <summary>
        /// Регулярное выражение, выявляющее английские буквы.
        /// </summary>
        private const string _englishRegex = @"(^[a-zA-Z]+(-[a-zA-Z]+)*$)";

        /// <summary>
        /// Регулярное выражение, выявляющее английские буквы.
        /// </summary>
        private const string _ageRegex = @"^\d+$";

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст.
        /// </summary>
        private int _age;

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public virtual int MinAge { get; } = 0;

        /// <summary>
        /// Масимальный возраст.
        /// </summary>
        public virtual int MaxAge { get; } = 120;

        /// <summary>
        /// Объект класс Person по умолчанию.
        /// </summary>
        public PersonBase() : this("Неизвестно", "Неизвестно", 18, Gender.Male)
        { }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        public PersonBase(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name
        { 
            get
            {
                return _name;
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
                    _name = IsCorrectName(value);
                }
            }
        }
        //TODO: XML+
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname 
        {
            get
            {
                return _surname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "Введена пустая строка.");
                }
                else if (!IsSameLanguage(Name, value))
                {
                    throw new ArgumentOutOfRangeException(
                        "Фамилия и имя не должны быть написаны на разных языках.");
                }
                else
                {
                    _surname = IsCorrectName(value);
                }
            } 
        }

        //TODO: XML+
        /// <summary>
        /// Возраст.
        /// </summary>
        public virtual int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > MaxAge || value < MinAge)
                {
                    throw new ArgumentException(
                        //TODO: to const+
                        $"Введите число из диапазона от {MinAge} до {MaxAge}.");

                }
                else
                {
                    _age = IsCorrectAge(value);
                }
            }
        }

        //TODO: XML+
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Проверяет корректность введенных данных./>.
        /// </summary>
        /// <param name="Name">Имя объекта.</param>
        /// <returns>Корректное имя или фамилия./>.</returns>
        public string IsCorrectName(string name)
        {
            string correctName;
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            if (name.Contains("-"))
            {

                string[] words = name.Split(new char[] { '-' });
                if (words.Length == 2)
                {
                    //TODO: RSDN+
                    if ((Regex.IsMatch(words[0], _russianRegex)
                        && Regex.IsMatch(words[1], _russianRegex))
                        ||
                        (Regex.IsMatch(words[0], _englishRegex)
                        && Regex.IsMatch(words[1], _englishRegex)))
                    {
                        words[0] = textInfo.ToTitleCase(words[0]);
                        words[1] = textInfo.ToTitleCase(words[1]);
                        correctName = string.Join("-", words);
                    }
                    else
                    {
                        throw new ArgumentException("Составное имя и фамилия должны" +
                            " содержать только русские или английские буквы.");
                    }
                }
                else
                {
                    throw new ArgumentException("Некорректное значение");
                }
            }
            else
            {
                if (Regex.IsMatch(name, _russianRegex) ||
                    Regex.IsMatch(name, _englishRegex))
                {
                    correctName = textInfo.ToTitleCase(name);
                }
                else
                {
                    throw new ArgumentException("Имя и фамилия должны " +
                        "содержать только русские или английские буквы.");
                }
            }
            return correctName;
        }

        /// <summary>
        /// Проверяет написание фамилии и имени на одинаковом языке./>.
        /// </summary>
        /// <param name="name">Имя объекта.</param>
        /// <param name="surname">Имя объекта.</param>
        /// <returns>Булевое выражение./>.</returns>
        public bool IsSameLanguage(string name, string surname)
        {
            bool sameLanguage = false;

            if (Regex.IsMatch(name, _russianRegex) &&
                    Regex.IsMatch(surname, _russianRegex) ||
                    (Regex.IsMatch(name, _englishRegex)
                    && Regex.IsMatch(surname, _englishRegex)))
            {
                sameLanguage = true;
            }

            return sameLanguage;
        }

        /// <summary>
        /// Проверяет возраст на корректность./>.
        /// </summary>
        /// <param name="age">Имя объекта.</param>
        /// <returns>Возраст/>.</returns>
        public int IsCorrectAge(int age)
        {
            string stringAge = Convert.ToString(age);
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
        /// Возвращает строку с информацией об объекте.
        /// </summary>
        public abstract string GetInfo();

    }
}