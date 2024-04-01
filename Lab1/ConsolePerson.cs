using ClassesLab1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    public class ConsolePerson
    {
        /// <summary>
        /// Чтение объекта класса Person с консоли.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public static Person ReadConsolePerson()
        {
            Person person = new Person();

            while (true)
            {
                try
                {
                    Console.Write("Введите имя: ");
                    person.Name = Console.ReadLine();
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите фамилию: ");
                    person.Surname = Console.ReadLine();
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            while (true)
            {
                try
                {
                    Console.Write("Введите возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат." +
                        " Введите целое число от 1 до 120.");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Введите пол (женский - 0; мужской - 1): ");
                    person.Gender = (Gender)Convert.ToInt32(Console.ReadLine());
                    if (person.Gender == Gender.Female || person.Gender == Gender.Male)
                    {
                        break;
                    }
                    else
                    {
                        throw new ArgumentException("Ошибка!" +
                            " Введите число 0 или 1.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Не верный формат!" +
                        " Введите число 0 или 1.");
                }
            }

            return person;
        }
    }
}
