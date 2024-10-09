using ClassesLab1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            List<Action> actions = new List<Action>
            {
                () =>
                {
                    Console.WriteLine("Введите имя:");
                    person.Name = Console.ReadLine();
                },

                () =>
                {
                     Console.WriteLine("Введите фамилию:");
                     person.Surname = Console.ReadLine();
                },

                () =>
                {
                     Console.WriteLine("Введите возраст:");
                     person.Age = Convert.ToInt32(Console.ReadLine());
                },

                () =>
                {
                     Console.WriteLine("Введите пол (M - мужской, F,Ж - женский):");
                     string gender = Console.ReadLine().ToUpper();

                    switch (gender)
                    {
                        case "M":
                        case "М":
                            person.Gender = Gender.Male;
                            break;
                        case "F":
                        case "Ж":
                            person.Gender = Gender.Female;
                            break;
                        default:
                            throw new ArgumentException
                                 ("Введите пол (M - мужской, F,Ж - женский):");

                    }
                }
            };

            foreach (Action action in actions)
            {
                ParseAction(action);
            }
            return person;           
        }

        public static void ParseAction(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception ex)
                {
                    var exceptionType = ex.GetType();
                    if (exceptionType == typeof(FormatException) ||
                        exceptionType == typeof(ArgumentOutOfRangeException) ||
                        exceptionType == typeof(ArgumentException) ||
                        exceptionType == typeof(InvalidOperationException))
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }

        }
    }
}
