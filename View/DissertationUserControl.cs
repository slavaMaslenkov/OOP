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
