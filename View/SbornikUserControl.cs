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
