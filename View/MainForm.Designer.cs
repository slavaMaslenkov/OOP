namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _cardGroupBox = new GroupBox();
            cardDataGridView = new DataGridView();
            _saveButton = new Button();
            _loadButton = new Button();
            _randomButton = new Button();
            _editingGroupBox = new GroupBox();
            _clearButton = new Button();
            _deleteButton = new Button();
            _resetButton = new Button();
            _filterButton = new Button();
            _addButton = new Button();
            _cardGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardDataGridView).BeginInit();
            _editingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _cardGroupBox
            // 
            _cardGroupBox.Controls.Add(cardDataGridView);
            _cardGroupBox.Location = new Point(12, 54);
            _cardGroupBox.Name = "_cardGroupBox";
            _cardGroupBox.Size = new Size(728, 319);
            _cardGroupBox.TabIndex = 0;
            _cardGroupBox.TabStop = false;
            _cardGroupBox.Text = "Библиотечные карточки";
            _cardGroupBox.Enter += groupBox1_Enter;
            // 
            // cardDataGridView
            // 
            cardDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cardDataGridView.Location = new Point(6, 22);
            cardDataGridView.Name = "cardDataGridView";
            cardDataGridView.Size = new Size(716, 291);
            cardDataGridView.TabIndex = 0;
            // 
            // _saveButton
            // 
            _saveButton.Location = new Point(18, 12);
            _saveButton.Name = "_saveButton";
            _saveButton.Size = new Size(96, 23);
            _saveButton.TabIndex = 1;
            _saveButton.Text = "Сохранить";
            _saveButton.UseVisualStyleBackColor = true;
            // 
            // _loadButton
            // 
            _loadButton.Location = new Point(141, 12);
            _loadButton.Name = "_loadButton";
            _loadButton.Size = new Size(96, 23);
            _loadButton.TabIndex = 2;
            _loadButton.Text = "Загрузить";
            _loadButton.UseVisualStyleBackColor = true;
            // 
            // _randomButton
            // 
            _randomButton.Location = new Point(638, 12);
            _randomButton.Name = "_randomButton";
            _randomButton.Size = new Size(96, 23);
            _randomButton.TabIndex = 3;
            _randomButton.Text = "Random";
            _randomButton.UseVisualStyleBackColor = true;
            // 
            // _editingGroupBox
            // 
            _editingGroupBox.Controls.Add(_clearButton);
            _editingGroupBox.Controls.Add(_deleteButton);
            _editingGroupBox.Controls.Add(_resetButton);
            _editingGroupBox.Controls.Add(_filterButton);
            _editingGroupBox.Controls.Add(_addButton);
            _editingGroupBox.Location = new Point(12, 379);
            _editingGroupBox.Name = "_editingGroupBox";
            _editingGroupBox.Size = new Size(728, 59);
            _editingGroupBox.TabIndex = 4;
            _editingGroupBox.TabStop = false;
            _editingGroupBox.Text = "Редактирование списка";
            // 
            // _clearButton
            // 
            _clearButton.Location = new Point(615, 22);
            _clearButton.Name = "_clearButton";
            _clearButton.Size = new Size(96, 23);
            _clearButton.TabIndex = 9;
            _clearButton.Text = "Очистить";
            _clearButton.UseVisualStyleBackColor = true;
            // 
            // _deleteButton
            // 
            _deleteButton.Location = new Point(492, 22);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(96, 23);
            _deleteButton.TabIndex = 8;
            _deleteButton.Text = "Удалить";
            _deleteButton.UseVisualStyleBackColor = true;
            // 
            // _resetButton
            // 
            _resetButton.Location = new Point(259, 23);
            _resetButton.Name = "_resetButton";
            _resetButton.Size = new Size(96, 23);
            _resetButton.TabIndex = 7;
            _resetButton.Text = "Сбросить";
            _resetButton.UseVisualStyleBackColor = true;
            // 
            // _filterButton
            // 
            _filterButton.Location = new Point(129, 23);
            _filterButton.Name = "_filterButton";
            _filterButton.Size = new Size(96, 23);
            _filterButton.TabIndex = 6;
            _filterButton.Text = "Фильтр";
            _filterButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(6, 23);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(96, 23);
            _addButton.TabIndex = 5;
            _addButton.Text = "Добавить";
            _addButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(768, 450);
            Controls.Add(_editingGroupBox);
            Controls.Add(_randomButton);
            Controls.Add(_loadButton);
            Controls.Add(_saveButton);
            Controls.Add(_cardGroupBox);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотечные карточки";
            Load += MainForm_Load;
            _cardGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cardDataGridView).EndInit();
            _editingGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _cardGroupBox;
        private DataGridView cardDataGridView;
        private Button _saveButton;
        private Button _loadButton;
        private Button _randomButton;
        private GroupBox _editingGroupBox;
        private Button _clearButton;
        private Button _deleteButton;
        private Button _resetButton;
        private Button _filterButton;
        private Button _addButton;
    }
}
