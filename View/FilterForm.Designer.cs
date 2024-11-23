namespace View
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _cardTypeGroupBox = new GroupBox();
            _sbornikCheckBox = new CheckBox();
            _magazineCheckBox = new CheckBox();
            _dissertationCheckBox = new CheckBox();
            _bookCheckBox = new CheckBox();
            _parametersGroupBox = new GroupBox();
            _nameTextBox = new TextBox();
            _surnameTextBox = new TextBox();
            _nameCheckBox = new CheckBox();
            _surnameCheckBox = new CheckBox();
            _okButton = new Button();
            _cardTypeGroupBox.SuspendLayout();
            _parametersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _cardTypeGroupBox
            // 
            _cardTypeGroupBox.Controls.Add(_sbornikCheckBox);
            _cardTypeGroupBox.Controls.Add(_magazineCheckBox);
            _cardTypeGroupBox.Controls.Add(_dissertationCheckBox);
            _cardTypeGroupBox.Controls.Add(_bookCheckBox);
            _cardTypeGroupBox.Location = new Point(12, 12);
            _cardTypeGroupBox.Name = "_cardTypeGroupBox";
            _cardTypeGroupBox.Size = new Size(287, 131);
            _cardTypeGroupBox.TabIndex = 0;
            _cardTypeGroupBox.TabStop = false;
            _cardTypeGroupBox.Text = "Тип карточки";
            // 
            // _sbornikCheckBox
            // 
            _sbornikCheckBox.AutoSize = true;
            _sbornikCheckBox.Location = new Point(11, 102);
            _sbornikCheckBox.Name = "_sbornikCheckBox";
            _sbornikCheckBox.Size = new Size(133, 19);
            _sbornikCheckBox.TabIndex = 3;
            _sbornikCheckBox.Text = "Статья из сборника";
            _sbornikCheckBox.UseVisualStyleBackColor = true;
            // 
            // _magazineCheckBox
            // 
            _magazineCheckBox.AutoSize = true;
            _magazineCheckBox.Location = new Point(11, 77);
            _magazineCheckBox.Name = "_magazineCheckBox";
            _magazineCheckBox.Size = new Size(128, 19);
            _magazineCheckBox.TabIndex = 2;
            _magazineCheckBox.Text = "Статья из журнала";
            _magazineCheckBox.UseVisualStyleBackColor = true;
            // 
            // _dissertationCheckBox
            // 
            _dissertationCheckBox.AutoSize = true;
            _dissertationCheckBox.Location = new Point(11, 52);
            _dissertationCheckBox.Name = "_dissertationCheckBox";
            _dissertationCheckBox.Size = new Size(97, 19);
            _dissertationCheckBox.TabIndex = 1;
            _dissertationCheckBox.Text = "Диссертация";
            _dissertationCheckBox.UseVisualStyleBackColor = true;
            // 
            // _bookCheckBox
            // 
            _bookCheckBox.AutoSize = true;
            _bookCheckBox.Location = new Point(11, 27);
            _bookCheckBox.Name = "_bookCheckBox";
            _bookCheckBox.Size = new Size(58, 19);
            _bookCheckBox.TabIndex = 0;
            _bookCheckBox.Text = "Книга";
            _bookCheckBox.UseVisualStyleBackColor = true;
            // 
            // _parametersGroupBox
            // 
            _parametersGroupBox.Controls.Add(_nameTextBox);
            _parametersGroupBox.Controls.Add(_surnameTextBox);
            _parametersGroupBox.Controls.Add(_nameCheckBox);
            _parametersGroupBox.Controls.Add(_surnameCheckBox);
            _parametersGroupBox.Location = new Point(12, 149);
            _parametersGroupBox.Name = "_parametersGroupBox";
            _parametersGroupBox.Size = new Size(287, 83);
            _parametersGroupBox.TabIndex = 1;
            _parametersGroupBox.TabStop = false;
            _parametersGroupBox.Text = "Параметры карточки";
            // 
            // _nameTextBox
            // 
            _nameTextBox.Location = new Point(171, 46);
            _nameTextBox.Name = "_nameTextBox";
            _nameTextBox.Size = new Size(100, 23);
            _nameTextBox.TabIndex = 7;
            // 
            // _surnameTextBox
            // 
            _surnameTextBox.Location = new Point(171, 18);
            _surnameTextBox.Name = "_surnameTextBox";
            _surnameTextBox.Size = new Size(100, 23);
            _surnameTextBox.TabIndex = 6;
            // 
            // _nameCheckBox
            // 
            _nameCheckBox.AutoSize = true;
            _nameCheckBox.Location = new Point(11, 50);
            _nameCheckBox.Name = "_nameCheckBox";
            _nameCheckBox.Size = new Size(78, 19);
            _nameCheckBox.TabIndex = 5;
            _nameCheckBox.Text = "Название";
            _nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // _surnameCheckBox
            // 
            _surnameCheckBox.AutoSize = true;
            _surnameCheckBox.Location = new Point(11, 22);
            _surnameCheckBox.Name = "_surnameCheckBox";
            _surnameCheckBox.Size = new Size(117, 19);
            _surnameCheckBox.TabIndex = 4;
            _surnameCheckBox.Text = "Фамилия автора";
            _surnameCheckBox.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            _okButton.Location = new Point(12, 238);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(96, 23);
            _okButton.TabIndex = 6;
            _okButton.Text = "OK";
            _okButton.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(313, 269);
            Controls.Add(_okButton);
            Controls.Add(_parametersGroupBox);
            Controls.Add(_cardTypeGroupBox);
            MaximizeBox = false;
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройка фильтрации";
            _cardTypeGroupBox.ResumeLayout(false);
            _cardTypeGroupBox.PerformLayout();
            _parametersGroupBox.ResumeLayout(false);
            _parametersGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _cardTypeGroupBox;
        private CheckBox _sbornikCheckBox;
        private CheckBox _magazineCheckBox;
        private CheckBox _dissertationCheckBox;
        private CheckBox _bookCheckBox;
        private GroupBox _parametersGroupBox;
        private CheckBox _nameCheckBox;
        private CheckBox _surnameCheckBox;
        private TextBox _nameTextBox;
        private TextBox _surnameTextBox;
        private Button _okButton;
    }
}