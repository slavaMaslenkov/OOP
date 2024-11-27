using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// UserControl для добавления сборника.
    /// </summary>
    public partial class SbornikUserControl : UserControl, ICardAddable
    {
        /// <summary>
        /// Конструктор класса SbornikUserControl.
        /// </summary>
        public SbornikUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Формирование сборника.
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
                        (_nameOfBookTextBox, "Название статьи", 50),
                        (_nameOfSbornikTextBox, "Название сборника", 50),
                        (_placeOfPublicationTextBox, "Место публикации", 20),
                        (_publishingHouseTextBox, "Издательство", 20),
                        (_yearTextBox, "Год издания", 4),
                        (_startSheetTextBox, "Начальная страница", 3),
                        (_endSheetTextBox, "Последняя страница", 3)
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

                return new Sbornik()
                {
                    Surname =_surnameTextBox.Text,
                    Name =_nameTextBox.Text,
                    Patronymic =_patronymicTextBox.Text,
                    Title =_nameOfBookTextBox.Text,
                    NameOfSbornik =_nameOfSbornikTextBox.Text,
                    PlaceOfPublication =_placeOfPublicationTextBox.Text,
                    PublishingHouse =_publishingHouseTextBox.Text,
                    Year =_yearTextBox.Text,
                    StartSheet =_startSheetTextBox.Text,
                    EndSheet =_endSheetTextBox.Text,
                };
            }
        }
    }
}
