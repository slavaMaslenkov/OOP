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
    /// Форма настроек фильтрации.
    /// </summary>
    public partial class FilterForm : Form
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
        /// Событие фильтрации списка.
        /// </summary>
        public EventHandler CardsFiltered;

        /// <summary>
        /// Конструктор класса <see cref="FilterForm"/>.
        /// </summary>
        /// <param name="cardList">Список движений.</param>
        public FilterForm(BindingList<CardBase> cardList)
        {
            _cardList = cardList;
            _cardList.ListChanged += Filter;
            InitializeComponent();
            _surnameTextBox.Enabled = false;
            _nameTextBox.Enabled = false;
            _okButton.Enabled = false;
            _okButton.Click += Filter;
            _surnameCheckBox.CheckedChanged += ActivateSurnameTextBox;
            _nameCheckBox.CheckedChanged += ActivateNameTextBox;
            _bookCheckBox.CheckedChanged += ActivateOkButton;
            _dissertationCheckBox.CheckedChanged += ActivateOkButton;
            _magazineCheckBox.CheckedChanged += ActivateOkButton;
            _sbornikCheckBox.CheckedChanged += ActivateOkButton;
            _surnameCheckBox.CheckedChanged += ActivateOkButton;
            _nameCheckBox.CheckedChanged += ActivateOkButton;
        }

        /// <summary>
        /// Метод активации кнопки "Ок".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ActivateOkButton(object sender, EventArgs e)
        {
            bool activate = _bookCheckBox.Checked
                || _dissertationCheckBox.Checked
                || _magazineCheckBox.Checked
                || _sbornikCheckBox.Checked
                || _surnameCheckBox.Checked
                || _nameCheckBox.Checked;

            _okButton.Enabled = activate;
        }

        /// <summary>
        /// Метод активации поля ввода фамилии автора.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ActivateSurnameTextBox(object sender, EventArgs e)
        {
            _surnameTextBox.Enabled = _surnameCheckBox.Checked;
        }

        /// <summary>
        /// Метод активации поля ввода названия книги/статьи/диссертации.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void ActivateNameTextBox(object sender, EventArgs e)
        {
            _nameTextBox.Enabled = _nameCheckBox.Checked;
        }

        /// <summary>
        /// Фильтрация списка.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект, содержащий данные о событии.</param>
        private void Filter(object sender, EventArgs e)
        {
            _filteredCardList = new BindingList<CardBase>();
            BindingList<CardBase> test = new();

            bool check = _bookCheckBox.Checked
                || _dissertationCheckBox.Checked
                || _magazineCheckBox.Checked
                || _sbornikCheckBox.Checked;

            if (_bookCheckBox.Checked)
            {
                FilterByType(_cardList, test,
                    typeof(Book));
            }

            if (_dissertationCheckBox.Checked)
            {
                FilterByType(_cardList, test,
                    typeof(Dissertation));
            }

            if (_magazineCheckBox.Checked)
            {
                FilterByType(_cardList, test,
                    typeof(Magazine));
            }

            if (_sbornikCheckBox.Checked)
            {
                FilterByType(_cardList, test,
                    typeof(Sbornik));
            }

            foreach (var card in _cardList)
            {
                if (test.Contains(card))
                {
                    _filteredCardList.Add(card);
                }
            }

            if (check)
            {
                CheckParameters(_filteredCardList);
            }
            else
            {
                CheckParameters(_cardList);
            }

            CardsFiltered.Invoke(this,
                new CardFilteredEvent(_filteredCardList));
        }

        /// <summary>
        /// Метод проверки параметров.
        /// </summary>
        /// <param name="cardList">Список карточек.</param>
        public void CheckParameters(BindingList<CardBase> cardList)
        {
            if (_nameCheckBox.Checked)
            {
                if (!string.IsNullOrWhiteSpace(_nameTextBox.Text))
                {
                    _filteredCardList =
                        FilterByName(cardList,_nameTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Введите название",
                        "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            if (_surnameCheckBox.Checked)
            {
                if (!string.IsNullOrWhiteSpace(_surnameTextBox.Text))
                {
                    _filteredCardList =
                        FilterBySurname(cardList,_surnameTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Введите фамилию автора",
                        "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Метод фильтрации по типу карточки.
        /// </summary>
        /// <param name="originalList">Исходный список.</param>
        /// <param name="filteredList">Отфильтрованный список.</param>
        /// <param name="type">Тип карточки.</param>
        public static void FilterByType(BindingList<CardBase> originalList,
            BindingList<CardBase> filteredList, Type type)
        {
            foreach (var item in originalList)
            {
                if (type.IsInstanceOfType(item))
                {
                    filteredList.Add(item);
                }
            }
        }

        /// <summary>
        /// Метод фильтрации по фамилии автора.
        /// </summary>
        /// <param name="originalList">Исходный список.</param>
        /// <param name="surname">Фамилия автора.</param>
        /// <returns>Отфильтрованный список.</returns>
        private static BindingList<CardBase> FilterBySurname(
            BindingList<CardBase> originalList, string surname)
        {
            BindingList<CardBase> filteredList = new();
            foreach (var element in originalList)
            {
                if (element.Surname == surname)
                {
                    filteredList.Add(element);
                }
            }

            return filteredList;
        }

        /// <summary>
        /// Метод фильтрации по названию книги/статьи/диссертации.
        /// </summary>
        /// <param name="originalList">Исходный список.</param>
        /// <param name="name">Название.</param>
        /// <returns>Отфильтрованный список.</returns>
        private static BindingList<CardBase> FilterByName(
            BindingList<CardBase> originalList, string name)
        {
            BindingList<CardBase> filteredList = new();
            foreach (var element in originalList)
            {
                if (element.Name == name)
                {
                    filteredList.Add(element);
                }
            }

            return filteredList;
        }
    }
}
