using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Класс ввода кода специальности.
    /// </summary>
    public class SpecialityCodeBox : TextBox
    {
        /// <summary>
        /// Конструктор класса NumericBox.
        /// </summary>
        public SpecialityCodeBox()
        {
            KeyPress += new KeyPressEventHandler(ValidateInput);
        }

        /// <summary>
        /// Обработка каждого нажатия клавиши.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        public virtual void ValidateInput(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (!char.IsDigit(symbol) && symbol != '.' && symbol != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
