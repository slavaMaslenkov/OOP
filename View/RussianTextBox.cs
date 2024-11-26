using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Класс ввода только русских букв.
    /// </summary>
    public class RussianTextBox : TextBox
    {
        private readonly Regex _regex = new Regex(@"^[А-Яа-яЁё]+$");

        /// <summary>
        /// Конструктор класса RussianTextBox.
        /// </summary>
        public RussianTextBox()
        {
            KeyPress += new KeyPressEventHandler(ValidateInput);
        }

        /// <summary>
        /// Проверка каждого нажатия клавиши.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        public virtual void ValidateInput(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if ( symbol == (char)Keys.Back || symbol == ' ')
            {
                e.Handled = false;
            }
            else if(!Regex.IsMatch(symbol.ToString(), @"^[А-Яа-яЁё\s]$"))
            {
                e.Handled = true;
            }
        }
    }
}
