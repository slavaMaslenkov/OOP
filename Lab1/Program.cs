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

            /*Adult Slava = new Adult("Слава", "Масленков", 23, Gender.Male, "1a1111", "1111", null,"Oeprator");
            Console.WriteLine(Slava.GetInfo());*/

            var person = personList1.GetPersonByIndex(3);

            switch (person)
            {
                case Adult adult:
                    Console.WriteLine(((Adult)person).AreYouAdult());
                    break;
                case Child child:
                    Console.WriteLine(((Child)person).AreYouChild());
                    break;
            }
            _ = Console.ReadKey();
        }
    }
}