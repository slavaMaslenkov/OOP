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
            Book Slava = new Book("Масленков", "Слава", "Эдуардович", "Книга", "Абакан", "СТС", "ADD", 2022,122);
            Console.WriteLine(Slava.GetInfo());

            Sbornik Dis = new Sbornik();
            Console.WriteLine(Dis.GetInfo());
        }
    }
}
