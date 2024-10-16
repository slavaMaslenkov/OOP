using ClassesLab1;
using System;

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
                Random rnd = new Random();
                int ChildOrAdult = rnd.Next(2);
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

            Type typePeople = people.GetType();

            Console.WriteLine($"Тип данных 4-го человека списке:" +
                $" {typePeople}");

            if (typePeople == typeof(Adult))
            {
                Console.WriteLine(((Adult)people).AreYouAdult());
            }

            if (typePeople == typeof(Child))
            {
                Console.WriteLine(((Child)people).AreYouChild());
            }

            _ = Console.ReadKey();
        }
    }
}