using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Класс для ввода +/- чисел.
    /// </summary>
    public class NegativeNumericBox : TextBox
    {
        /// <summary>
        /// Конструктор класса NegativeNumericBox.
        /// </summary>
        public NegativeNumericBox()
        {
            KeyPress += new KeyPressEventHandler(ValidateInput);
        }

        /// <summary>
        /// Корректировка ввода данных.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        public virtual void ValidateInput(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            char symbol = e.KeyChar;
            if (!char.IsDigit(symbol) && symbol != (char)Keys.Back
                && symbol != '-')
            {
                e.Handled = true;
            }
            if (symbol == '-')
            {
                // Разрешаем только если он вводится первым символом
                if (textBox.SelectionStart != 0 || textBox.Text.Contains('-'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
