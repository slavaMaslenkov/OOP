using LibraryCards;

namespace ConsoleLoader

{
    /// <summary>
    /// Класс Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод Main.
        /// </summary>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Для выхода из программы нажмите \'x\'\n" +
                    "Для начала работы нажмите любую другую клавишу...");

                ConsoleKeyInfo userInput = Console.ReadKey(true);
                Console.WriteLine();

                switch (userInput.KeyChar)
                {
                    case 'х':
                    case 'x':
                    case 'X':
                    case 'Х':
                        {
                            return;
                        }
                    default:
                        {
                            break;
                        }
                }

                CardBase card = CardsReader.ReadCard();
                Console.WriteLine($"Привет ");
            }
        }
    }
}
