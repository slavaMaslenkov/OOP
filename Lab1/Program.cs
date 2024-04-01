﻿using ClassesLab1;

namespace Lab1
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод Main.
        /// </summary>
        public static void Main()
        {
            
            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();
            RandomPerson randomPerson = new RandomPerson();

            personList1.AddPerson(randomPerson.GetRandomPerson());
            personList1.AddPerson(randomPerson.GetRandomPerson());
            personList1.AddPerson(randomPerson.GetRandomPerson());
            personList2.AddPerson(randomPerson.GetRandomPerson());
            personList2.AddPerson(randomPerson.GetRandomPerson());
            personList2.AddPerson(randomPerson.GetRandomPerson());

            Console.ReadKey();
            Console.WriteLine("Вывод первого списка:");
            Console.WriteLine(personList1.PersonInfo());

            Console.ReadKey();
            Console.WriteLine("Вывод второго списка:");
            Console.WriteLine(personList2.PersonInfo());
            
            personList2.AddPerson(personList1.GetPersonByIndex(2));
            
            Console.ReadKey();
            Console.WriteLine("Вывод второго списка:");
            Console.WriteLine(personList2.PersonInfo());
            
            personList1.RemovePersonByIndex(2);
            
            Console.ReadKey();
            Console.WriteLine("Вывод второго списка:");
            Console.WriteLine(personList1.PersonInfo());
            
            personList2.ClearPersonList();
            
            Console.ReadKey();
            Console.WriteLine("Вывод второго списка:");
            Console.WriteLine(personList2.PersonInfo());
        }
    }
}