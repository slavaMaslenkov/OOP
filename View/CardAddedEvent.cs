using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    /// <summary>
    /// Класс события добавления карточки.
    /// </summary>
    internal class CardAddedEvent : EventArgs
    {
        /// <summary>
        /// Свойство для получения карточки.
        /// </summary>
        public CardBase CardBase { get; }

        /// <summary>
        /// Конструктор класса CardAddedEvent.
        /// </summary>
        /// <param name="cardBase">Объект класса CardBase.</param>
        /// <exception cref="ArgumentNullException">Исключение.</exception>
        public CardAddedEvent(CardBase cardBase)
        {
            CardBase = cardBase;
        }
    }
}
