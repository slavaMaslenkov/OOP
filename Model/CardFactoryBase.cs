using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Базовый класс CardFactoryBase.
    /// </summary>
    public abstract class CardFactoryBase
    {
        /// <summary>
        /// Получение экземпляра издания.
        /// </summary>
        /// <param name="cardType">Тип библиотечного издания.</param>
        /// <returns>Экземпляр класса EditionBase.</returns>
        public abstract CardBase GetInstance(CardType editionType);

        /// <summary>
        /// Метод возвращающий случайную строку из массива.
        /// </summary>
        /// <param name="words">Массив из строк</param>
        /// <returns>Случайная строка.</returns>
        public string GetRandomString(string[] words)
        {
            var random = new Random();
            string randomWords = words[random.Next(words.Length)];
            return randomWords;
        }

        /// <summary>
        /// Метод возвращает случайное число в указанном диапазоне.
        /// </summary>
        /// <param name="minValue">Минимальное число.</param>
        /// <param name="maxValue">Максимальное число</param>
        /// <returns>Случайное число в строковом формате.</returns>
        public string GetRandomValue(int minValue, int maxValue)
        {
            var rnd = new Random();
            var tmpValue = rnd.Next(minValue, maxValue);
            return Convert.ToString(tmpValue);
        }

        /// <summary>
        /// Метод возвращает случайное число в указанном диапазоне.
        /// </summary>
        /// <param name="minValue">Минимальное число.</param>
        /// <param name="maxValue">Максимальное число</param>
        /// <returns>Случайное число.</returns>
        public int GetRandomDigit(int minValue, int maxValue)
        {
            var rnd = new Random();
            var tmpValue = rnd.Next(minValue, maxValue);
            return tmpValue;
        }
    }
}
