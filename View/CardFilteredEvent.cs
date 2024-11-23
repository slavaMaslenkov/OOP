using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    /// <summary>
    /// Класс события фильтрации.
    /// </summary>
    internal class CardFilteredEvent : EventArgs
    {
        /// <summary>
        /// Свойство для получения отфильтрованного списка.
        /// </summary>
        public BindingList<CardBase> FilteredCardList { get; }

        /// <summary>
        /// Конструктор класса CardFilteredEvent.
        /// </summary>
        /// <param name="filteredCardList">Отфильтрованный список.</param>
        /// <exception cref="ArgumentNullException">Исключение.</exception>
        public CardFilteredEvent(BindingList<CardBase>
            filteredCardList)
        {
            if (filteredCardList == null)
            {
                throw new ArgumentNullException();
            }

            FilteredCardList = filteredCardList;
        }
    }
}
