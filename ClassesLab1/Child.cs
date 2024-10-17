﻿using System;
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
        /// РОдитель женщина.
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
        /// Партнер мама.
        /// </summary>
        public Adult Father { get; set; }

        //TODO: RSDN+
        /// <summary>
        /// Партнер папа.
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Образовательное учреждение.
        /// </summary>
        public string EducationalInstitution { get; set; }

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
