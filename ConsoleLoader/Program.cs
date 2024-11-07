using LibraryCards;

namespace ConsoleLoader

{
    /// <summary>
    /// Класс Program.
    /// </summary>
    public class Program
    {
        internal static void Main()
        {
            Console.WriteLine("Hello, World!");
            Book Slava = new Book("Слава", "Масленков", "Эдуардович", "Книга", "Абакан", "СТС", "ADD", 2022,122);
            Console.WriteLine(Slava.GetInfo());
        }
    }
}
