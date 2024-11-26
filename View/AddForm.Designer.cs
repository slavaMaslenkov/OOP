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
            _dissertationUserControl = new DissertationUserControl();
            _sbornikUserControl = new SbornikUserControl();
            _magazineUserControl = new MagazineUserControl();
            _bookUserControl = new BookUserControl();
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
            _cardTypeGroupBox.Location = new Point(6, 16);
            _cardTypeGroupBox.Margin = new Padding(3, 4, 3, 4);
            _cardTypeGroupBox.Name = "_cardTypeGroupBox";
            _cardTypeGroupBox.Padding = new Padding(3, 4, 3, 4);
            _cardTypeGroupBox.Size = new Size(315, 183);
            _cardTypeGroupBox.TabIndex = 0;
            _cardTypeGroupBox.TabStop = false;
            _cardTypeGroupBox.Text = "Тип карточки";
            // 
            // _sbornikRadioButton
            // 
            _sbornikRadioButton.AutoSize = true;
            _sbornikRadioButton.Location = new Point(18, 139);
            _sbornikRadioButton.Margin = new Padding(3, 4, 3, 4);
            _sbornikRadioButton.Name = "_sbornikRadioButton";
            _sbornikRadioButton.Size = new Size(166, 24);
            _sbornikRadioButton.TabIndex = 3;
            _sbornikRadioButton.TabStop = true;
            _sbornikRadioButton.Text = "Статья из сборника";
            _sbornikRadioButton.UseVisualStyleBackColor = true;
            // 
            // _magazineRadioButton
            // 
            _magazineRadioButton.AutoSize = true;
            _magazineRadioButton.Location = new Point(18, 105);
            _magazineRadioButton.Margin = new Padding(3, 4, 3, 4);
            _magazineRadioButton.Name = "_magazineRadioButton";
            _magazineRadioButton.Size = new Size(159, 24);
            _magazineRadioButton.TabIndex = 2;
            _magazineRadioButton.TabStop = true;
            _magazineRadioButton.Text = "Статья из журнала";
            _magazineRadioButton.UseVisualStyleBackColor = true;
            // 
            // _dissertationRadioButton
            // 
            _dissertationRadioButton.AutoSize = true;
            _dissertationRadioButton.Location = new Point(18, 72);
            _dissertationRadioButton.Margin = new Padding(3, 4, 3, 4);
            _dissertationRadioButton.Name = "_dissertationRadioButton";
            _dissertationRadioButton.Size = new Size(120, 24);
            _dissertationRadioButton.TabIndex = 1;
            _dissertationRadioButton.TabStop = true;
            _dissertationRadioButton.Text = "Диссертация";
            _dissertationRadioButton.UseVisualStyleBackColor = true;
            // 
            // _bookRadioButton
            // 
            _bookRadioButton.AutoSize = true;
            _bookRadioButton.Location = new Point(18, 39);
            _bookRadioButton.Margin = new Padding(3, 4, 3, 4);
            _bookRadioButton.Name = "_bookRadioButton";
            _bookRadioButton.Size = new Size(71, 24);
            _bookRadioButton.TabIndex = 0;
            _bookRadioButton.TabStop = true;
            _bookRadioButton.Text = "Книга";
            _bookRadioButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(6, 820);
            _addButton.Margin = new Padding(3, 4, 3, 4);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(110, 31);
            _addButton.TabIndex = 6;
            _addButton.Text = "Добавить";
            _addButton.UseVisualStyleBackColor = true;
            // 
            // _closeButton
            // 
            _closeButton.Location = new Point(211, 820);
            _closeButton.Margin = new Padding(3, 4, 3, 4);
            _closeButton.Name = "_closeButton";
            _closeButton.Size = new Size(110, 31);
            _closeButton.TabIndex = 7;
            _closeButton.Text = "Закрыть";
            _closeButton.UseVisualStyleBackColor = true;
            // 
            // _parametersGroupBox
            // 
            _parametersGroupBox.Controls.Add(_dissertationUserControl);
            _parametersGroupBox.Controls.Add(_sbornikUserControl);
            _parametersGroupBox.Controls.Add(_magazineUserControl);
            _parametersGroupBox.Controls.Add(_bookUserControl);
            _parametersGroupBox.Location = new Point(6, 207);
            _parametersGroupBox.Margin = new Padding(3, 4, 3, 4);
            _parametersGroupBox.Name = "_parametersGroupBox";
            _parametersGroupBox.Padding = new Padding(3, 4, 3, 4);
            _parametersGroupBox.Size = new Size(315, 605);
            _parametersGroupBox.TabIndex = 1;
            _parametersGroupBox.TabStop = false;
            _parametersGroupBox.Text = "Параметры карточки";
            // 
            // dissertationUserControl
            // 
            _dissertationUserControl.Location = new Point(6, 29);
            _dissertationUserControl.Margin = new Padding(3, 5, 3, 5);
            _dissertationUserControl.Name = "dissertationUserControl";
            _dissertationUserControl.Size = new Size(301, 540);
            _dissertationUserControl.TabIndex = 3;
            // 
            // sbornikUserControl
            // 
            _sbornikUserControl.Location = new Point(7, 29);
            _sbornikUserControl.Margin = new Padding(3, 5, 3, 5);
            _sbornikUserControl.Name = "sbornikUserControl";
            _sbornikUserControl.Size = new Size(301, 444);
            _sbornikUserControl.TabIndex = 2;
            // 
            // magazineUserControl
            // 
            _magazineUserControl.Location = new Point(7, 29);
            _magazineUserControl.Margin = new Padding(3, 5, 3, 5);
            _magazineUserControl.Name = "magazineUserControl";
            _magazineUserControl.Size = new Size(299, 407);
            _magazineUserControl.TabIndex = 1;
            // 
            // bookUserControl
            // 
            _bookUserControl.Location = new Point(7, 29);
            _bookUserControl.Margin = new Padding(3, 5, 3, 5);
            _bookUserControl.Name = "bookUserControl";
            _bookUserControl.Size = new Size(298, 403);
            _bookUserControl.TabIndex = 0;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(335, 867);
            Controls.Add(_closeButton);
            Controls.Add(_addButton);
            Controls.Add(_parametersGroupBox);
            Controls.Add(_cardTypeGroupBox);
            Margin = new Padding(3, 4, 3, 4);
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
        private BookUserControl _bookUserControl;
        private MagazineUserControl _magazineUserControl;
        private DissertationUserControl _dissertationUserControl;
        private SbornikUserControl _sbornikUserControl;
    }
}