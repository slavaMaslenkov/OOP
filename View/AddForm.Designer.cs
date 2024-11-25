namespace View
{
    partial class AddForm
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
            _sbornikRadioButton = new RadioButton();
            _magazineRadioButton = new RadioButton();
            _dissertationRadioButton = new RadioButton();
            _bookRadioButton = new RadioButton();
            _addButton = new Button();
            _closeButton = new Button();
            _parametersGroupBox = new GroupBox();
            bookUserControl = new BookUserControl();
            magazineUserControl = new MagazineUserControl();
            sbornikUserControl = new SbornikUserControl();
            dissertationUserControl = new DissertationUserControl();
            _cardTypeGroupBox.SuspendLayout();
            _parametersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // _cardTypeGroupBox
            // 
            _cardTypeGroupBox.Controls.Add(_sbornikRadioButton);
            _cardTypeGroupBox.Controls.Add(_magazineRadioButton);
            _cardTypeGroupBox.Controls.Add(_dissertationRadioButton);
            _cardTypeGroupBox.Controls.Add(_bookRadioButton);
            _cardTypeGroupBox.Location = new Point(5, 12);
            _cardTypeGroupBox.Name = "_cardTypeGroupBox";
            _cardTypeGroupBox.Size = new Size(276, 137);
            _cardTypeGroupBox.TabIndex = 0;
            _cardTypeGroupBox.TabStop = false;
            _cardTypeGroupBox.Text = "Тип карточки";
            // 
            // _sbornikRadioButton
            // 
            _sbornikRadioButton.AutoSize = true;
            _sbornikRadioButton.Location = new Point(16, 104);
            _sbornikRadioButton.Name = "_sbornikRadioButton";
            _sbornikRadioButton.Size = new Size(132, 19);
            _sbornikRadioButton.TabIndex = 3;
            _sbornikRadioButton.TabStop = true;
            _sbornikRadioButton.Text = "Статья из сборника";
            _sbornikRadioButton.UseVisualStyleBackColor = true;
            // 
            // _magazineRadioButton
            // 
            _magazineRadioButton.AutoSize = true;
            _magazineRadioButton.Location = new Point(16, 79);
            _magazineRadioButton.Name = "_magazineRadioButton";
            _magazineRadioButton.Size = new Size(127, 19);
            _magazineRadioButton.TabIndex = 2;
            _magazineRadioButton.TabStop = true;
            _magazineRadioButton.Text = "Статья из журнала";
            _magazineRadioButton.UseVisualStyleBackColor = true;
            // 
            // _dissertationRadioButton
            // 
            _dissertationRadioButton.AutoSize = true;
            _dissertationRadioButton.Location = new Point(16, 54);
            _dissertationRadioButton.Name = "_dissertationRadioButton";
            _dissertationRadioButton.Size = new Size(96, 19);
            _dissertationRadioButton.TabIndex = 1;
            _dissertationRadioButton.TabStop = true;
            _dissertationRadioButton.Text = "Диссертация";
            _dissertationRadioButton.UseVisualStyleBackColor = true;
            // 
            // _bookRadioButton
            // 
            _bookRadioButton.AutoSize = true;
            _bookRadioButton.Location = new Point(16, 29);
            _bookRadioButton.Name = "_bookRadioButton";
            _bookRadioButton.Size = new Size(57, 19);
            _bookRadioButton.TabIndex = 0;
            _bookRadioButton.TabStop = true;
            _bookRadioButton.Text = "Книга";
            _bookRadioButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(5, 615);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(96, 23);
            _addButton.TabIndex = 6;
            _addButton.Text = "Добавить";
            _addButton.UseVisualStyleBackColor = true;
            // 
            // _closeButton
            // 
            _closeButton.Location = new Point(116, 615);
            _closeButton.Name = "_closeButton";
            _closeButton.Size = new Size(96, 23);
            _closeButton.TabIndex = 7;
            _closeButton.Text = "Закрыть";
            _closeButton.UseVisualStyleBackColor = true;
            // 
            // _parametersGroupBox
            // 
            _parametersGroupBox.Controls.Add(dissertationUserControl);
            _parametersGroupBox.Controls.Add(sbornikUserControl);
            _parametersGroupBox.Controls.Add(magazineUserControl);
            _parametersGroupBox.Controls.Add(bookUserControl);
            _parametersGroupBox.Location = new Point(5, 155);
            _parametersGroupBox.Name = "_parametersGroupBox";
            _parametersGroupBox.Size = new Size(276, 454);
            _parametersGroupBox.TabIndex = 1;
            _parametersGroupBox.TabStop = false;
            _parametersGroupBox.Text = "Параметры карточки";
            // 
            // bookUserControl
            // 
            bookUserControl.Location = new Point(6, 22);
            bookUserControl.Name = "bookUserControl";
            bookUserControl.Size = new Size(261, 302);
            bookUserControl.TabIndex = 0;
            // 
            // magazineUserControl
            // 
            magazineUserControl.Location = new Point(6, 22);
            magazineUserControl.Name = "magazineUserControl";
            magazineUserControl.Size = new Size(262, 305);
            magazineUserControl.TabIndex = 1;
            // 
            // sbornikUserControl
            // 
            sbornikUserControl.Location = new Point(6, 22);
            sbornikUserControl.Name = "sbornikUserControl";
            sbornikUserControl.Size = new Size(263, 333);
            sbornikUserControl.TabIndex = 2;
            // 
            // dissertationUserControl
            // 
            dissertationUserControl.Location = new Point(5, 22);
            dissertationUserControl.Name = "dissertationUserControl";
            dissertationUserControl.Size = new Size(263, 405);
            dissertationUserControl.TabIndex = 3;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(293, 650);
            Controls.Add(_closeButton);
            Controls.Add(_addButton);
            Controls.Add(_parametersGroupBox);
            Controls.Add(_cardTypeGroupBox);
            MaximizeBox = false;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить";
            _cardTypeGroupBox.ResumeLayout(false);
            _cardTypeGroupBox.PerformLayout();
            _parametersGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox _cardTypeGroupBox;
        private RadioButton _bookRadioButton;
        private RadioButton _sbornikRadioButton;
        private RadioButton _magazineRadioButton;
        private RadioButton _dissertationRadioButton;
        private Button _addButton;
        private Button _closeButton;
        private GroupBox _parametersGroupBox;
        private BookUserControl bookUserControl;
        private MagazineUserControl magazineUserControl;
        private DissertationUserControl dissertationUserControl;
        private SbornikUserControl sbornikUserControl;
    }
}