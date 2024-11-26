using Model;

namespace View
{
    /// <summary>
    /// Форма для добавления карточки.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Конструктор класса AddForm.
        /// </summary>
        public AddForm()
        {
            InitializeComponent();

            _closeButton.Click += ClickCancelButton;

            _bookRadioButton.CheckedChanged +=
                ChangeBookStatus;

            _dissertationRadioButton.CheckedChanged +=
                ChangeDissertationStatus;

            _magazineRadioButton.CheckedChanged +=
                ChangeMagazineStatus;

            _sbornikRadioButton.CheckedChanged +=
                ChangeSbornikStatus;

            _addButton.Click += ClickAddButton;
        }
        
        /// <summary>
        /// Событие добавления карточки.
        /// </summary>
        public EventHandler CardAdded;
        
        /// <summary>
        /// Метод изменения статуса карточки Книга.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeBookStatus(object sender, EventArgs e)
        {
            bookUserControl.Visible = true;
            dissertationUserControl.Visible = false;
            magazineUserControl.Visible = false;
            sbornikUserControl.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса карточки Диссертация.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeDissertationStatus(
            object sender, EventArgs e)
        {
            bookUserControl.Visible = false;
            dissertationUserControl.Visible = true;
            magazineUserControl.Visible = false;
            sbornikUserControl.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса карточки Журнал.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeMagazineStatus(
            object sender, EventArgs e)
        {
            bookUserControl.Visible = false;
            dissertationUserControl.Visible = false;
            magazineUserControl.Visible = true;
            sbornikUserControl.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса карточки Сборник.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeSbornikStatus(
            object sender, EventArgs e)
        {
            bookUserControl.Visible = false;
            dissertationUserControl.Visible = false;
            magazineUserControl.Visible = false;
            sbornikUserControl.Visible = true;
        }

        /// <summary>
        /// Метод нажатия на кнопку "Добавить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickAddButton(object sender, EventArgs e)
        {
            try
            {
                //TODO: зачем здесь консоль?
                Console.WriteLine($"_surnameTextBox: {sbornikUserControl._surnameTextBox.Text}");
                Console.WriteLine($"_startSheetTextBox: {sbornikUserControl._startSheetTextBox.Text}");

                CardBase cardBase = null;

                //TODO: много нарушений инкапсуляции
                if (bookUserControl.Visible)
                {
                    cardBase = new Book()
                    {
                        Surname = bookUserControl.
                            _surnameTextBox.Text,
                        Name = bookUserControl.
                            _nameTextBox.Text,
                        Patronymic = bookUserControl.
                            _patronymicTextBox.Text,
                        Title = bookUserControl.
                            _nameOfBookTextBox.Text,
                        PlaceOfPublication = bookUserControl.
                            _placeOfPublicationTextBox.Text,
                        PublishingHouse = bookUserControl.
                            _publishingHouseTextBox.Text,
                        AdditionalInformation = bookUserControl.
                            _additionalInformationTextBox.Text,
                        Year = bookUserControl.
                            _yearTextBox.Text,
                        Sheet = bookUserControl.
                            _sheetTextBox.Text,
                    };
                }

                if (dissertationUserControl.Visible)
                {
                    cardBase = new Dissertation()
                    {
                        Surname = dissertationUserControl.
                            _surnameTextBox.Text,
                        Name = dissertationUserControl.
                            _nameTextBox.Text,
                        Patronymic = dissertationUserControl.
                            _patronymicTextBox.Text,
                        Title = dissertationUserControl.
                            _nameOfBookTextBox.Text,
                        KindOfDissert = dissertationUserControl.
                            _kindOfDissertTextBox.Text,
                        BranchOfScience = dissertationUserControl.
                            _branchOfScienceTextBox.Text,
                        SpecialtyCode = dissertationUserControl.
                            _specialtyCodeTextBox.Text,
                        Organization = dissertationUserControl.
                            _organizationTextBox.Text,
                        City = dissertationUserControl.
                            _cityTextBox.Text,
                        NameOfSpeciality = dissertationUserControl.
                            _nameOfSpecialityTextBox.Text,
                        Year = dissertationUserControl.
                            _yearTextBox.Text,
                        Sheet = dissertationUserControl.
                            _sheetTextBox.Text,
                    };
                }

                if (magazineUserControl.Visible)
                {
                    cardBase = new Magazine()
                    {
                        Surname = magazineUserControl.
                            _surnameTextBox.Text,
                        Name = magazineUserControl.
                            _nameTextBox.Text,
                        Patronymic = magazineUserControl.
                            _patronymicTextBox.Text,
                        Title = magazineUserControl.
                            _nameOfBookTextBox.Text,
                        NameOfMagazine = magazineUserControl.
                            _nameOfMagazineTextBox.Text,
                        NumberOfMagazine = Convert.ToInt32(
                            magazineUserControl.
                            _numberOfMagazineTextBox.Text),
                        Year = magazineUserControl.
                            _yearTextBox.Text,
                        StartSheet = magazineUserControl.
                            _startSheetTextBox.Text,
                        EndSheet = magazineUserControl.
                            _endSheetTextBox.Text,
                    };
                }

                if (sbornikUserControl.Visible)
                {
                    cardBase = new Sbornik()
                    {
                        Surname = sbornikUserControl.
                            _surnameTextBox.Text,
                        Name = sbornikUserControl.
                            _nameTextBox.Text,
                        Patronymic = sbornikUserControl.
                            _patronymicTextBox.Text,
                        Title = sbornikUserControl.
                            _nameOfBookTextBox.Text,
                        NameOfSbornik = sbornikUserControl.
                            _nameOfSbornikTextBox.Text,
                        PlaceOfPublication = sbornikUserControl.
                            _placeOfPublicationTextBox.Text,
                        PublishingHouse = sbornikUserControl.
                            _publishingHouseTextBox.Text,
                        Year = sbornikUserControl.
                            _yearTextBox.Text,
                        StartSheet = sbornikUserControl.
                            _startSheetTextBox.Text,
                        EndSheet = sbornikUserControl.
                            _endSheetTextBox.Text,
                    };
                }

                CardAdded?.Invoke(this,
                    new CardAddedEvent(cardBase));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\n{ex.StackTrace}");
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку "Закрыть".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickCancelButton(object sender, EventArgs e)
        {
            Close();
        }

    }


}
