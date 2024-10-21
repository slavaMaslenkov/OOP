using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    //TODO: XML+
    /// <summary>
    /// Класс определяющий ребенка.
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Родитель мужчина.
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Родитель женщина.
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Образовательное учреждение.
        /// </summary>
        private string _educationalInstitution;

        /// <summary>
        /// Минимальный возраст.
        /// </summary>
        public override int MinAge { get; } = 0;

        /// <summary>
        /// Масимальный возраст.
        /// </summary>
        public override int MaxAge { get; } = 18;

        /// <summary>
        /// Объект класса Child по умолчанию.
        /// </summary>
        public Child() : this("Неизвестно", "Неизвестно", 18, Gender.Male, null, null, null)
        { }

        /// <summary>
        /// Конструктор класса Child.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="father">Родитель мужчина.</param>
        /// <param name="mother">РОдитель женщина.</param>
        /// <param name="educationalInstitution">Детский сад.</param>
        public Child(string name, string surname, int age, Gender gender, Adult father,
            Adult mother, string educationalInstitution) : base(name, surname, age, gender)
        {
            Father = father;
            Mother = mother;
            EducationalInstitution = educationalInstitution;
        }

        //TODO: RSDN+
        /// <summary>
        /// Gets or sets партнер мама.
        /// </summary>
        public Adult Father
        {
            get
            {
                return _father;
            }
            set
            {
                if (value?.Gender == Gender.Female)
                {
                    throw new ArgumentException(
                        "Отец должен быть мужского пола.");
                }
                else
                {
                   _father = value;
                }
            }
        } 

        //TODO: RSDN+
        /// <summary>
        /// Gets or sets партнер папа.
        /// </summary>
        public Adult Mother
        {
            get
            {
                return _mother;
            }
            set
            {
                if (value?.Gender == Gender.Male)
                {
                    throw new ArgumentException(
                        "Мать должна быть женского пола.");
                }
                else
                {
                     _mother = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets образовательное учреждение.
        /// </summary>
        public string EducationalInstitution
        {
            get
            {
                return _educationalInstitution;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _educationalInstitution = "В образовательное учреждение не ходит.";
                }
                else
                {
                    _educationalInstitution = value;
                }
            }
        }

        /// <summary>
        /// Возвращает строку с информацией об объекте.
        /// </summary>
        /// <returns>Информация об объекте.</returns>
        public override string GetInfo()
        {
            string info;
            if (Mother == null && Father == null)
            {
                info = "Нет родителей";
            }
            else if (Mother == null)
            {
                info = $"{Father.Name + " " + Father.Surname}";
            }
            else if (Father == null)
            {
                info = $"{Mother.Name + " " + Mother.Surname}";
            }
            else
            {
                info = $"{Mother.Name + " " + Mother.Surname}" + " "+
                    $"{Father.Name + " " + Father.Surname}";
            }

            return $"Имя: {Name}\tФамилия: {Surname}" +
                    $"\tВозраст: {Age}\tПол: {Gender}" +
                    $"\tРодители: {info}" +
                    $"\tУчреждение: {EducationalInstitution}\n";
        }

        /// <summary>
        /// Возвращает строку с информацией об объекте.
        /// </summary>
        /// <returns>Информация об объекте.</returns>
        public string AreYouChild()
        {
            return $"Я ребенок!";
        }
    }

}
