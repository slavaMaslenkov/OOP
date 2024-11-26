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
                    if (_kindOfDissertTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_branchOfScienceTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_specialtyCodeTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_organizationTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_cityTextBox.Text.Length > 50)
                        throw new ArgumentException("Строка не должна" +
                            " превышать 50 символов.");
                    if (_nameOfSpecialityTextBox.Text.Length > 50)
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
