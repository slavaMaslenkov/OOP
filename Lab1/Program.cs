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
            Person person1 = new Person("Slava", "Maslenkov", 24, Gender.Male);
            Person person2 = new Person("Slav", "Maslenko", 2, Gender.Male);
            Person person3 = new Person("Sla", "Maоооslen", 244, Gender.Male);
            Person person4 = new Person("Дарко", "Щокотов", 24, Gender.Male);
            Person person5 = new Person("Гнал", "Оллллоло", 2, Gender.Male);
            Person person6 = new Person("Литр", "Masleааn", 244, Gender.Male);
            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();
            personList1.AddPerson(person1);
            personList1.AddPerson(person2);
            personList1.AddPerson(person3);
            personList2.AddPerson(person4);
            personList2.AddPerson(person5);
            personList2.AddPerson(person6);

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