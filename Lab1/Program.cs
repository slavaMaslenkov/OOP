using PersonLibrary;
using System;
using System.Reflection;

namespace Lab1
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод Main.
        /// </summary>
        internal static void Main()
        {
            PersonList personList1 = new PersonList();
            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                int ChildOrAdult = random.Next(2);
                if (ChildOrAdult == 1)
                {
                    personList1.AddPerson(RandomPerson.GetRandomAdult());
                }
                else
                {
                    personList1.AddPerson(RandomPerson.GetRandomChild());
                }
            }

            Console.ReadKey();
            Console.WriteLine("Вывод первого списка:");
            Console.WriteLine(personList1.PersonInfo());

            var people = personList1.GetPersonByIndex(3);

            //TODO: switch-case+
            switch (people.GetType().Name)
            {
                case "Adult":
                    Console.WriteLine(((Adult)people).AreYouAdult());
                    break;
                case "Child":
                    Console.WriteLine(((Child)people).AreYouChild());
                    break;
            }
            _ = Console.ReadKey();
        }
    }
}