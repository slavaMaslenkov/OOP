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
    /// <summary>
    /// UserControl для добавления книги.
    /// </summary>
    public partial class BookUserControl : UserControl, ICardAddable
    {
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
