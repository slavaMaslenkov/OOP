using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    //TODO: XML+
    /// <summary>
    /// UserControl для добавления книги.
    /// </summary>
    public partial class BookUserControl : UserControl, ICardAddable
    {
        //TODO: XML+
        /// <summary>
        /// Конструктор класса BookUserControl.
        /// </summary>
        public BookUserControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Формирование диссертации.
        /// </summary>
        public CardBase Card
        {
            get
            {
                try
                {
                    if (_surnameTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_nameTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_patronymicTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_nameOfBookTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_placeOfPublicationTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_publishingHouseTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_additionalInformationTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_yearTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_sheetTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;

                }

                return new Book()
                {
                    Surname =_surnameTextBox.Text,
                    Name = _nameTextBox.Text,
                    Patronymic =_patronymicTextBox.Text,
                    Title = _nameOfBookTextBox.Text,
                    PlaceOfPublication =_placeOfPublicationTextBox.Text,
                    PublishingHouse =_publishingHouseTextBox.Text,
                    AdditionalInformation =_additionalInformationTextBox.Text,
                    Year = _yearTextBox.Text,
                    Sheet = _sheetTextBox.Text,
                };
            }
        }
    }
}
