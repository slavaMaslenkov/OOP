using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    /// <summary> 
    /// Интерфейс добавления карточки.
    /// </summary>
    public interface ICardAddable
    {
        /// <summary> 
        /// Метод добавления карточки.
        /// </summary>
        CardBase Card { get; }
    }
}
