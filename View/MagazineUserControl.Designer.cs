namespace View
{
    partial class MagazineUserControl
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
            _endSheetTextBox = new NumericBox();
            _startSheetLabel = new Label();
            _startSheetTextBox = new NumericBox();
            _yearTextBox = new NumericBox();
            _yearLabel = new Label();
            _endSheetLabel = new Label();
            _numberOfMagazineTextBox = new NumericBox();
            _nameOfMagazineTextBox = new TextBox();
            _numberOfMagazineLabel = new Label();
            _nameOfMagazineLabel = new Label();
            _nameOfBookTextBox = new TextBox();
            _patronymicTextBox = new RussianTextBox();
            _nameTextBox = new RussianTextBox();
            _surnameTextBox = new RussianTextBox();
            _titleLabel = new Label();
            _patronymicLabel = new Label();
            _nameLabel = new Label();
            _surnameLabel = new Label();
            SuspendLayout();
            // 
            // _endSheetTextBox
            // 
            _endSheetTextBox.Location = new Point(153, 274);
            _endSheetTextBox.Name = "_endSheetTextBox";
            _endSheetTextBox.Size = new Size(100, 23);
            _endSheetTextBox.TabIndex = 35;
            // 
            // _startSheetLabel
            // 
            _startSheetLabel.AutoSize = true;
            _startSheetLabel.Location = new Point(3, 244);
            _startSheetLabel.Name = "_startSheetLabel";
            _startSheetLabel.Size = new Size(91, 15);
            _startSheetLabel.TabIndex = 34;
            _startSheetLabel.Text = "Начальная стр.";
            // 
            // _startSheetTextBox
            // 
            _startSheetTextBox.Location = new Point(153, 241);
            _startSheetTextBox.Name = "_startSheetTextBox";
            _startSheetTextBox.Size = new Size(100, 23);
            _startSheetTextBox.TabIndex = 33;
            // 
            // _yearTextBox
            // 
            _yearTextBox.Location = new Point(153, 206);
            _yearTextBox.Name = "_yearTextBox";
            _yearTextBox.Size = new Size(100, 23);
            _yearTextBox.TabIndex = 32;
            // 
            // _yearLabel
            // 
            _yearLabel.AutoSize = true;
            _yearLabel.Location = new Point(3, 209);
            _yearLabel.Name = "_yearLabel";
            _yearLabel.Size = new Size(73, 15);
            _yearLabel.TabIndex = 31;
            _yearLabel.Text = "Год издания";
            // 
            // _endSheetLabel
            // 
            _endSheetLabel.AutoSize = true;
            _endSheetLabel.Location = new Point(3, 277);
            _endSheetLabel.Name = "_endSheetLabel";
            _endSheetLabel.Size = new Size(91, 15);
            _endSheetLabel.TabIndex = 30;
            _endSheetLabel.Text = "Последняя стр.";
            // 
            // _numberOfMagazineTextBox
            // 
            _numberOfMagazineTextBox.Location = new Point(153, 171);
            _numberOfMagazineTextBox.Name = "_numberOfMagazineTextBox";
            _numberOfMagazineTextBox.Size = new Size(100, 23);
            _numberOfMagazineTextBox.TabIndex = 29;
            // 
            // _nameOfMagazineTextBox
            // 
            _nameOfMagazineTextBox.Location = new Point(153, 138);
            _nameOfMagazineTextBox.Name = "_nameOfMagazineTextBox";
            _nameOfMagazineTextBox.Size = new Size(100, 23);
            _nameOfMagazineTextBox.TabIndex = 28;
            // 
            // _numberOfMagazineLabel
            // 
            _numberOfMagazineLabel.AutoSize = true;
            _numberOfMagazineLabel.Location = new Point(3, 174);
            _numberOfMagazineLabel.Name = "_numberOfMagazineLabel";
            _numberOfMagazineLabel.Size = new Size(96, 15);
            _numberOfMagazineLabel.TabIndex = 27;
            _numberOfMagazineLabel.Text = "Номер журнала";
            // 
            // _nameOfMagazineLabel
            // 
            _nameOfMagazineLabel.AutoSize = true;
            _nameOfMagazineLabel.Location = new Point(3, 141);
            _nameOfMagazineLabel.Name = "_nameOfMagazineLabel";
            _nameOfMagazineLabel.Size = new Size(110, 15);
            _nameOfMagazineLabel.TabIndex = 26;
            _nameOfMagazineLabel.Text = "Название журнала";
            // 
            // _nameOfBookTextBox
            // 
            _nameOfBookTextBox.Location = new Point(153, 107);
            _nameOfBookTextBox.Name = "_nameOfBookTextBox";
            _nameOfBookTextBox.Size = new Size(100, 23);
            _nameOfBookTextBox.TabIndex = 25;
            // 
            // _patronymicTextBox
            // 
            _patronymicTextBox.Location = new Point(153, 75);
            _patronymicTextBox.Name = "_patronymicTextBox";
            _patronymicTextBox.Size = new Size(100, 23);
            _patronymicTextBox.TabIndex = 24;
            // 
            // _nameTextBox
            // 
            _nameTextBox.Location = new Point(153, 42);
            _nameTextBox.Name = "_nameTextBox";
            _nameTextBox.Size = new Size(100, 23);
            _nameTextBox.TabIndex = 23;
            // 
            // _surnameTextBox
            // 
            _surnameTextBox.Location = new Point(153, 7);
            _surnameTextBox.Name = "_surnameTextBox";
            _surnameTextBox.Size = new Size(100, 23);
            _surnameTextBox.TabIndex = 22;
            // 
            // _titleLabel
            // 
            _titleLabel.AutoSize = true;
            _titleLabel.Location = new Point(3, 110);
            _titleLabel.Name = "_titleLabel";
            _titleLabel.Size = new Size(59, 15);
            _titleLabel.TabIndex = 21;
            _titleLabel.Text = "Название";
            // 
            // _patronymicLabel
            // 
            _patronymicLabel.AutoSize = true;
            _patronymicLabel.Location = new Point(3, 78);
            _patronymicLabel.Name = "_patronymicLabel";
            _patronymicLabel.Size = new Size(98, 15);
            _patronymicLabel.TabIndex = 20;
            _patronymicLabel.Text = "Отчество автора";
            // 
            // _nameLabel
            // 
            _nameLabel.AutoSize = true;
            _nameLabel.Location = new Point(3, 45);
            _nameLabel.Name = "_nameLabel";
            _nameLabel.Size = new Size(71, 15);
            _nameLabel.TabIndex = 19;
            _nameLabel.Text = "Имя автора";
            // 
            // _surnameLabel
            // 
            _surnameLabel.AutoSize = true;
            _surnameLabel.Location = new Point(3, 10);
            _surnameLabel.Name = "_surnameLabel";
            _surnameLabel.Size = new Size(98, 15);
            _surnameLabel.TabIndex = 18;
            _surnameLabel.Text = "Фамилия автора";
            // 
            // MagazineUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_endSheetTextBox);
            Controls.Add(_startSheetLabel);
            Controls.Add(_startSheetTextBox);
            Controls.Add(_yearTextBox);
            Controls.Add(_yearLabel);
            Controls.Add(_endSheetLabel);
            Controls.Add(_numberOfMagazineTextBox);
            Controls.Add(_nameOfMagazineTextBox);
            Controls.Add(_numberOfMagazineLabel);
            Controls.Add(_nameOfMagazineLabel);
            Controls.Add(_nameOfBookTextBox);
            Controls.Add(_patronymicTextBox);
            Controls.Add(_nameTextBox);
            Controls.Add(_surnameTextBox);
            Controls.Add(_titleLabel);
            Controls.Add(_patronymicLabel);
            Controls.Add(_nameLabel);
            Controls.Add(_surnameLabel);
            Name = "MagazineUserControl";
            Size = new Size(262, 305);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox _endSheetTextBox;
        internal Label _startSheetLabel;
        internal TextBox _startSheetTextBox;
        internal TextBox _yearTextBox;
        internal Label _yearLabel;
        internal Label _endSheetLabel;
        internal TextBox _numberOfMagazineTextBox;
        internal TextBox _nameOfMagazineTextBox;
        internal Label _numberOfMagazineLabel;
        internal Label _nameOfMagazineLabel;
        internal TextBox _nameOfBookTextBox;
        internal TextBox _patronymicTextBox;
        internal TextBox _nameTextBox;
        internal TextBox _surnameTextBox;
        internal Label _titleLabel;
        internal Label _patronymicLabel;
        internal Label _nameLabel;
        internal Label _surnameLabel;
    }
}
