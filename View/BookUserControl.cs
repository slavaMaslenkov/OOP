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
                    var textFieldLimits = new (TextBox TextBox, string FieldName, int MaxLength)[]
                    {
                        (_surnameTextBox, "Фамилия", 20),
                        (_nameTextBox, "Имя", 20),
                        (_patronymicTextBox, "Отчество", 20),
                        (_nameOfBookTextBox, "Название книги", 50),
                        (_placeOfPublicationTextBox, "Место публикации", 30),
                        (_publishingHouseTextBox, "Издательство", 30),
                        (_additionalInformationTextBox, "Доп.инфа", 30),
                        (_yearTextBox, "Год издания", 4),
                        (_sheetTextBox, "Начальная страница", 5)
                    };

                    foreach (var (textBox, fieldName, maxLength) in textFieldLimits)
                    {
                        if (textBox.Text.Length > maxLength)
                        {
                            throw new ArgumentException($"{fieldName} не должно " +
                                $"превышать {maxLength} символов.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
