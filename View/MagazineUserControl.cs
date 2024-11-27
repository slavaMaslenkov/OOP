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
    //TODO: XML+
    /// <summary>
    /// UserControl для добавления журнала.
    /// </summary>
    public partial class MagazineUserControl : UserControl, ICardAddable
    {
        /// <summary>
        /// Конструктор класса MagazineUserControl.
        /// </summary>
        public MagazineUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Формирование журнала.
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
                        (_nameOfMagazineTextBox, "Название журнала", 50),
                        (_numberOfMagazineTextBox, "Номер журнала", 5),
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

                return new Magazine()
                {
                    Surname =_surnameTextBox.Text,
                    Name =_nameTextBox.Text,
                    Patronymic =_patronymicTextBox.Text,
                    Title =_nameOfBookTextBox.Text,
                    NameOfMagazine =_nameOfMagazineTextBox.Text,
                    NumberOfMagazine =_numberOfMagazineTextBox.Text,
                    Year =_yearTextBox.Text,
                    StartSheet =_startSheetTextBox.Text,
                    EndSheet =_endSheetTextBox.Text,
                };
            }
        }
    }
}
