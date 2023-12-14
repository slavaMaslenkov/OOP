using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public enum Gender
    {
        male, female
    };
    internal class Person
    {
        private string name;
        private string surname;
        private string age;
        private Gender _gender;
        public Person(string name, string surname, string age, Gender gender)
        { 
            this.name = name;
            this.surname = surname; 
            this.age = age;
            this._gender = gender; 
            
        }
    }
}
