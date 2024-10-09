﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab1
{
    internal class Child : Person
    {
        /// <summary>
        /// Родитель мужчина.
        /// </summary>
        private Adult _parentM;

        /// <summary>
        /// Родитель женщина.
        /// </summary>
        private Adult _parentF;

        /// <summary>
        /// РОдитель женщина.
        /// </summary>
        private string _kindergarten;

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
        /// <param name="parentM">Родитель мужчина.</param>
        /// <param name="parentF">РОдитель женщина.</param>
        /// <param name="kindergarten">Детский сад.</param>
        public Child(string name, string surname, int age, Gender gender, Adult parentM,
            Adult parentF, string kindergarten) : base(name, surname, age, gender)
        {
            ParentM = parentM;
            ParentF = parentF;
            Kindergarten = kindergarten;
        }

        public Adult ParentM { get; set; }

        public Adult ParentF { get; set; }
        public string Kindergarten { get; set; }

        /// <summary>
        /// Возвращает строку с информацией об объекте.
        /// </summary>
        /// <returns>Информация об объекте.</returns>
        public override string GetInfo()
        {
            return $"Имя: {Name}\tФамилия: {Surname}" +
                    $"\tВозраст: {Age}\tПол: {Gender}+" +
                    $"\tОтец: {ParentM}+" +
                    $"\tМать: {ParentF}\tДетский сад: {Kindergarten}\n";
        }
                    
    }

}
