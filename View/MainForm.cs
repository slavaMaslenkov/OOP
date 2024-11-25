using System.ComponentModel;
using System.Xml.Serialization;
using Model;

namespace View
{
    /// <summary>
    /// Основная форма программы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список на форме.
        /// </summary>
        private BindingList<CardBase> _cardList;

        /// <summary>
        /// Отфильтрованный список.
        /// </summary>
        private BindingList<CardBase> _filteredCardList;
        
        /// <summary>
        /// Сериализация списка.
        /// </summary>
        private XmlSerializer _serializer = new XmlSerializer(
            typeof(BindingList<CardBase>));
        
        /// <summary>
        /// Состояние формы добавления.
        /// </summary>
        private bool _isAddFormOpened = false;

        /// <summary>
        /// Состояние формы фильтра.
        /// </summary>
        private bool _isFilterFormOpened = false;

        /// <summary>
        /// Состояние фильтра.
        /// </summary>
        private bool _isFiltered = false;

        private bool _isFilterFormClosed = false;
        
        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void LoadMainForm(object sender, EventArgs e)
        {
            _cardList = new BindingList<CardBase>();
            CreateTable(_cardList, cardDataGridView);
        }
        
        /// <summary>
        /// Метод создания таблицы на форме.
        /// </summary>
        /// <param name="cardList">Список движений.</param>
        /// <param name="dataGridView">Сетка.</param>
        public static void CreateTable(BindingList<CardBase> cardList,
            DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.DataSource = cardList;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }
        
        /// <summary>
        /// Конструктор класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _addButton.Click += ClickAddButton;
            //Добавить рандом
            
            _deleteButton.Click += ClickDeleteButton;
            _clearButton.Click += ClickClearButton;
            _saveButton.Click += ClickSaveButton;
            _loadButton.Click += ClickLoadButton;
            _filterButton.Click += ClickFilterButton;
            _resetButton.Click += ClickResetButton;

            UpdateButtonsStates();
        }

        /// <summary>
        /// Метод нажатия на кнопку "Добавить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickAddButton(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.CardAdded += AddedCard;
            _isAddFormOpened = true;
            UpdateButtonsStates();
            addForm.FormClosed += (s, args) =>
            {
                _isAddFormOpened = false;
                UpdateButtonsStates();
            };

            addForm.Show();
        }

        /// <summary>
        /// Метод нажатия на кнопку "Удалить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickDeleteButton(object sender, EventArgs e)
        {
            if (cardDataGridView.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    cardDataGridView.SelectedRows)
                {
                    if (row.DataBoundItem is CardBase card)
                    {
                        _cardList.Remove(card);
                        if (_filteredCardList is not null
                            && _filteredCardList.Count > 0)
                        {
                            _filteredCardList.Remove(card);
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Метод сохранения списка в файл.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickSaveButton(object sender, EventArgs e)
        {
            if (_cardList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*card.)|*.card|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName.ToString();

                using (var file = File.Create(filePath))
                {
                    _serializer.Serialize(file, _cardList);
                }
            }
        }

        /// <summary>
        /// Метод загрузки списка из файла.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickLoadButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.card)|*.card|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string filePath = openFileDialog.FileName.ToString();

            try
            {
                using (var file = new StreamReader(filePath))
                {
                    _cardList = (BindingList<CardBase>)
                        _serializer.Deserialize(file);
                }

                cardDataGridView.DataSource = _cardList;
            }
            catch (Exception)
            {
                MessageBox.Show("Файл поврежден!",
                    "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Метод нажатия на кнопку фильтра.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickFilterButton(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm(_cardList);

            filterForm.CardsFiltered += (sender, cardList)
                    => FilterCard(sender, cardList, filterForm);

            _isFilterFormClosed = true;

            _isFilterFormOpened = true;
            UpdateButtonsStates();
            filterForm.FormClosed += (s, args) =>
            {
                _isFilterFormOpened = false;
                filterForm = null;
                UpdateButtonsStates();
            };

            filterForm.Show();
        }
        
        /// <summary>
        /// Метод фильтрации.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="motionList">Список движений.</param>
        private void FilterCard(object sender, EventArgs cardList, FilterForm form)
        {
            CardFilteredEvent filterEventArgs =
                cardList as CardFilteredEvent;
            _filteredCardList = filterEventArgs?.FilteredCardList;

            bool filterCondition = _filteredCardList != null && _filteredCardList.Count > 0;
            bool visible = form?.Visible ?? false;

            if ((_isFilterFormClosed || visible) && filterCondition)
            {
                CreateTable(_filteredCardList, cardDataGridView);
            }

            _isFiltered = true;
            UpdateButtonsStates();
        }
        
        /// <summary>
        /// Метод нажатия на кнопку "Очистить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickClearButton(object sender, EventArgs e)
        {
            cardDataGridView.ClearSelection();
            foreach (DataGridViewRow row in cardDataGridView.Rows)
            {
                row.Selected = true;
            }
            foreach (DataGridViewRow row in
                    cardDataGridView.SelectedRows)
            {
                if (row.DataBoundItem is CardBase card)
                {
                    _cardList.Remove(card);
                    if (_filteredCardList is not null
                            && _filteredCardList.Count > 0)
                    {
                        _filteredCardList.Remove(card);
                    }
                }
            }
        }
        
        /// <summary>
        /// Метод нажатия на кнопку "Сбросить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ClickResetButton(object sender, EventArgs e)
        {
            CreateTable(_cardList, cardDataGridView);
            _isFilterFormClosed = false;
            _isFiltered = false;
            UpdateButtonsStates();
        }
        
        /// <summary>
        /// Метод обновления состояний кнопок.
        /// </summary>
        private void UpdateButtonsStates()
        {
            _addButton.Enabled = !_isFilterFormOpened &&
                !_isFiltered && !_isAddFormOpened;
            _filterButton.Enabled = !_isAddFormOpened &&
                !_isFilterFormOpened;
            _saveButton.Enabled = !_isFiltered;
            _loadButton.Enabled = !_isFiltered;
            _randomButton.Enabled = _saveButton.Enabled;
        }

        /// <summary>
        /// Обработчик добавления данных.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="cardBase">Объект класса CardBase.</param>
        private void AddedCard(object sender, EventArgs cardBase)
        {
            CardAddedEvent addedEventArgs =
                cardBase as CardAddedEvent;

            _cardList.Add(addedEventArgs?.CardBase);
        }
    }
}
