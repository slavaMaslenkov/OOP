using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View
{
    public class SpecialityCodeBox : TextBox
    {

        private readonly Regex _regex = new Regex(@"^\d{2}\.\d{2}\.\d{2}$");

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
