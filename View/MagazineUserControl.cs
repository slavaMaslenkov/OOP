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
