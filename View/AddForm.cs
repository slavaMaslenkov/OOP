using Model;

namespace View
{
    /// <summary>
    /// Форма для добавления карточки.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Список с UserControls.
        /// </summary>
        private List<ICardAddable> _cardAddableControls;

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

            _cardAddableControls = new List<ICardAddable>()
            {
                _bookUserControl, 
                _dissertationUserControl,
                _magazineUserControl, 
                _sbornikUserControl
            };
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
            _bookUserControl.Visible = true;
            _dissertationUserControl.Visible = false;
            _magazineUserControl.Visible = false;
            _sbornikUserControl.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса карточки Диссертация.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeDissertationStatus(
            object sender, EventArgs e)
        {
            _bookUserControl.Visible = false;
            _dissertationUserControl.Visible = true;
            _magazineUserControl.Visible = false;
            _sbornikUserControl.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса карточки Журнал.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeMagazineStatus(
            object sender, EventArgs e)
        {
            _bookUserControl.Visible = false;
            _dissertationUserControl.Visible = false;
            _magazineUserControl.Visible = true;
            _sbornikUserControl.Visible = false;
        }

        /// <summary>
        /// Метод изменения статуса карточки Сборник.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ChangeSbornikStatus(
            object sender, EventArgs e)
        {
            _bookUserControl.Visible = false;
            _dissertationUserControl.Visible = false;
            _magazineUserControl.Visible = false;
            _sbornikUserControl.Visible = true;
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
                //TODO: зачем здесь консоль?+
                CardBase cardBase = null;

                foreach (var userControl in _cardAddableControls)
                {
                    if (((UserControl)userControl).Visible)
                    {
                        cardBase = userControl.Card;
                    }
                }

                //TODO: много нарушений инкапсуляции+

                CardAdded?.Invoke(this,
                    new CardAddedEvent(cardBase));
            }
            catch (Exception ex)
            {
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
