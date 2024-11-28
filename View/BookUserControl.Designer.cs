namespace View
{
    partial class BookUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            _surnameLabel = new Label();
            _nameLabel = new Label();
            _patronymicLabel = new Label();
            _titleLabel = new Label();
            _surnameTextBox = new RussianTextBox();
            _nameTextBox = new RussianTextBox();
            _patronymicTextBox = new RussianTextBox();
            _nameOfBookTextBox = new TextBox();
            _placeOfPublicationLabel = new Label();
            _publishingHouseLabel = new Label();
            _placeOfPublicationTextBox = new TextBox();
            _publishingHouseTextBox = new TextBox();
            _additionalInformationLabel = new Label();
            _yearLabel = new Label();
            _additionalInformationTextBox = new TextBox();
            _yearTextBox = new NegativeNumericBox();
            _sheetLabel = new Label();
            _sheetTextBox = new NumericBox();
            SuspendLayout();
            // 
            // _surnameLabel
            // 
            _surnameLabel.AutoSize = true;
            _surnameLabel.Location = new Point(3, 10);
            _surnameLabel.Name = "_surnameLabel";
            _surnameLabel.Size = new Size(98, 15);
            _surnameLabel.TabIndex = 0;
            _surnameLabel.Text = "Фамилия автора";
            // 
            // _nameLabel
            // 
            _nameLabel.AutoSize = true;
            _nameLabel.Location = new Point(3, 45);
            _nameLabel.Name = "_nameLabel";
            _nameLabel.Size = new Size(71, 15);
            _nameLabel.TabIndex = 1;
            _nameLabel.Text = "Имя автора";
            // 
            // _patronymicLabel
            // 
            _patronymicLabel.AutoSize = true;
            _patronymicLabel.Location = new Point(3, 78);
            _patronymicLabel.Name = "_patronymicLabel";
            _patronymicLabel.Size = new Size(98, 15);
            _patronymicLabel.TabIndex = 2;
            _patronymicLabel.Text = "Отчество автора";
            // 
            // _titleLabel
            // 
            _titleLabel.AutoSize = true;
            _titleLabel.Location = new Point(3, 110);
            _titleLabel.Name = "_titleLabel";
            _titleLabel.Size = new Size(59, 15);
            _titleLabel.TabIndex = 3;
            _titleLabel.Text = "Название";
            // 
            // _surnameTextBox
            // 
            _surnameTextBox.Location = new Point(153, 7);
            _surnameTextBox.Name = "_surnameTextBox";
            _surnameTextBox.Size = new Size(100, 23);
            _surnameTextBox.TabIndex = 4;
            // 
            // _nameTextBox
            // 
            _nameTextBox.Location = new Point(153, 42);
            _nameTextBox.Name = "_nameTextBox";
            _nameTextBox.Size = new Size(100, 23);
            _nameTextBox.TabIndex = 5;
            // 
            // _patronymicTextBox
            // 
            _patronymicTextBox.Location = new Point(153, 75);
            _patronymicTextBox.Name = "_patronymicTextBox";
            _patronymicTextBox.Size = new Size(100, 23);
            _patronymicTextBox.TabIndex = 6;
            // 
            // _nameOfBookTextBox
            // 
            _nameOfBookTextBox.Location = new Point(153, 107);
            _nameOfBookTextBox.Name = "_nameOfBookTextBox";
            _nameOfBookTextBox.Size = new Size(100, 23);
            _nameOfBookTextBox.TabIndex = 7;
            // 
            // _placeOfPublicationLabel
            // 
            _placeOfPublicationLabel.AutoSize = true;
            _placeOfPublicationLabel.Location = new Point(3, 141);
            _placeOfPublicationLabel.Name = "_placeOfPublicationLabel";
            _placeOfPublicationLabel.Size = new Size(89, 15);
            _placeOfPublicationLabel.TabIndex = 8;
            _placeOfPublicationLabel.Text = "Место издания";
            // 
            // _publishingHouseLabel
            // 
            _publishingHouseLabel.AutoSize = true;
            _publishingHouseLabel.Location = new Point(3, 174);
            _publishingHouseLabel.Name = "_publishingHouseLabel";
            _publishingHouseLabel.Size = new Size(81, 15);
            _publishingHouseLabel.TabIndex = 9;
            _publishingHouseLabel.Text = "Издательство";
            // 
            // _placeOfPublicationTextBox
            // 
            _placeOfPublicationTextBox.Location = new Point(153, 138);
            _placeOfPublicationTextBox.Name = "_placeOfPublicationTextBox";
            _placeOfPublicationTextBox.Size = new Size(100, 23);
            _placeOfPublicationTextBox.TabIndex = 10;
            // 
            // _publishingHouseTextBox
            // 
            _publishingHouseTextBox.Location = new Point(153, 171);
            _publishingHouseTextBox.Name = "_publishingHouseTextBox";
            _publishingHouseTextBox.Size = new Size(100, 23);
            _publishingHouseTextBox.TabIndex = 11;
            // 
            // _additionalInformationLabel
            // 
            _additionalInformationLabel.AutoSize = true;
            _additionalInformationLabel.Location = new Point(3, 209);
            _additionalInformationLabel.Name = "_additionalInformationLabel";
            _additionalInformationLabel.Size = new Size(124, 15);
            _additionalInformationLabel.TabIndex = 12;
            _additionalInformationLabel.Text = "Сведения об издании";
            // 
            // _yearLabel
            // 
            _yearLabel.AutoSize = true;
            _yearLabel.Location = new Point(3, 244);
            _yearLabel.Name = "_yearLabel";
            _yearLabel.Size = new Size(73, 15);
            _yearLabel.TabIndex = 13;
            _yearLabel.Text = "Год издания";
            // 
            // _additionalInformationTextBox
            // 
            _additionalInformationTextBox.Location = new Point(153, 206);
            _additionalInformationTextBox.Name = "_additionalInformationTextBox";
            _additionalInformationTextBox.Size = new Size(100, 23);
            _additionalInformationTextBox.TabIndex = 14;
            // 
            // _yearTextBox
            // 
            _yearTextBox.Location = new Point(153, 241);
            _yearTextBox.Name = "_yearTextBox";
            _yearTextBox.Size = new Size(100, 23);
            _yearTextBox.TabIndex = 15;
            // 
            // _sheetLabel
            // 
            _sheetLabel.AutoSize = true;
            _sheetLabel.Location = new Point(3, 277);
            _sheetLabel.Name = "_sheetLabel";
            _sheetLabel.Size = new Size(120, 15);
            _sheetLabel.TabIndex = 16;
            _sheetLabel.Text = "Количество страниц";
            // 
            // _sheetTextBox
            // 
            _sheetTextBox.Location = new Point(153, 274);
            _sheetTextBox.Name = "_sheetTextBox";
            _sheetTextBox.Size = new Size(100, 23);
            _sheetTextBox.TabIndex = 17;
            // 
            // BookUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_sheetTextBox);
            Controls.Add(_sheetLabel);
            Controls.Add(_yearTextBox);
            Controls.Add(_additionalInformationTextBox);
            Controls.Add(_yearLabel);
            Controls.Add(_additionalInformationLabel);
            Controls.Add(_publishingHouseTextBox);
            Controls.Add(_placeOfPublicationTextBox);
            Controls.Add(_publishingHouseLabel);
            Controls.Add(_placeOfPublicationLabel);
            Controls.Add(_nameOfBookTextBox);
            Controls.Add(_patronymicTextBox);
            Controls.Add(_nameTextBox);
            Controls.Add(_surnameTextBox);
            Controls.Add(_titleLabel);
            Controls.Add(_patronymicLabel);
            Controls.Add(_nameLabel);
            Controls.Add(_surnameLabel);
            Name = "BookUserControl";
            Size = new Size(261, 302);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label _surnameLabel;
        internal Label _nameLabel;
        internal Label _patronymicLabel;
        internal Label _titleLabel;
        internal TextBox _surnameTextBox;
        internal TextBox _nameTextBox;
        internal TextBox _patronymicTextBox;
        internal TextBox _nameOfBookTextBox;
        internal Label _placeOfPublicationLabel;
        internal Label _publishingHouseLabel;
        internal TextBox _placeOfPublicationTextBox;
        internal TextBox _publishingHouseTextBox;
        internal Label _additionalInformationLabel;
        internal Label _yearLabel;
        internal TextBox _additionalInformationTextBox;
        internal TextBox _yearTextBox;
        internal Label _sheetLabel;
        internal TextBox _sheetTextBox;
    }
}
