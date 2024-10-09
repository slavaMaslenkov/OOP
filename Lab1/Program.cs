using ClassesLab1;

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
            
                             
            personList1.AddPerson(Person.GetRandomPerson());
            personList1.AddPerson(Person.GetRandomPerson());
            personList1.AddPerson(Person.GetRandomPerson());
            personList2.AddPerson(Person.GetRandomPerson());
            personList2.AddPerson(Person.GetRandomPerson());
            personList2.AddPerson(Person.GetRandomPerson());

            Console.ReadKey();
            Console.WriteLine("Вывод первого списка:");
            Console.WriteLine(personList1.PersonInfo());

            Console.ReadKey();
            Console.WriteLine("Вывод второго списка:");
            Console.WriteLine(personList2.PersonInfo());

            ///Person Slava = new("Slava", "Maslenkov", 15, 0);
            personList1.AddPerson(ConsolePerson.ReadConsolePerson());
            Console.ReadKey();
            Console.WriteLine("Добавление нового человека в первый список:");
            Console.WriteLine(personList1.PersonInfo());

            personList2.AddPerson(personList1.GetPersonByIndex(1));
            
            Console.ReadKey();
            Console.WriteLine("Копирование второго человека из 1 списка в конец 2:");
            Console.WriteLine(personList2.PersonInfo());
            
            personList1.RemovePersonByIndex(1);
            
            Console.ReadKey();
            Console.WriteLine("Удаление второго человека из 1 списка:");
            Console.WriteLine(personList1.PersonInfo());

            Console.ReadKey();
            Console.WriteLine("Вывод второго списка:");
            Console.WriteLine(personList2.PersonInfo());

            personList2.ClearPersonList();
            
            Console.ReadKey();
            Console.WriteLine("Очищение второго списка:");
            Console.WriteLine(personList2.PersonInfo());

            
        }
    }
}