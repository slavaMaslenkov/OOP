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
    /// UserControl для добавления диссертации.
    /// </summary>
    public partial class DissertationUserControl : UserControl, ICardAddable
    {
        /// <summary>
        /// Конструктор класса DissertationUserControl.
        /// </summary>
        public DissertationUserControl()
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
                    var textFieldLimits = new (TextBox TextBox, 
                        string FieldName, int MaxLength)[]
                    {
                        (_surnameTextBox, "Фамилия", 20),
                        (_nameTextBox, "Имя", 20),
                        (_patronymicTextBox, "Отчество", 20),
                        (_nameOfBookTextBox, "Название статьи", 50),
                        (_kindOfDissertTextBox, "Вид диссертации", 50),
                        (_branchOfScienceTextBox, "Отрасль наук", 20),
                        (_specialtyCodeTextBox, "Код специальности", 20),
                        (_organizationTextBox, "Организация", 10),
                        (_cityTextBox, "Город", 20),
                        (_nameOfSpecialityTextBox, "Название спец.", 20),
                        (_yearTextBox, "Год издания", 4),                        
                        (_sheetTextBox, "Количество страниц", 3)
                    };

                    foreach (var (textBox, fieldName, maxLength) 
                        in textFieldLimits)
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
                return new Dissertation()
                {
                    Surname =_surnameTextBox.Text,
                    Name = _nameTextBox.Text,
                    Patronymic =_patronymicTextBox.Text,
                    Title = _nameOfBookTextBox.Text,
                    KindOfDissert =_kindOfDissertTextBox.Text,
                    BranchOfScience =_branchOfScienceTextBox.Text,
                    SpecialtyCode =_specialtyCodeTextBox.Text,
                    Organization =_organizationTextBox.Text,
                    City = _cityTextBox.Text,
                    NameOfSpeciality =_nameOfSpecialityTextBox.Text,
                    Year = _yearTextBox.Text,
                    Sheet =_sheetTextBox.Text,
                };
            }
        }
    }
}
