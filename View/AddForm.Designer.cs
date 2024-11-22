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
            _parametersGroupBox = new GroupBox();
            bookUserControl1 = new BookUserControl();
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
            _cardTypeGroupBox.Size = new Size(352, 137);
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
            // _parametersGroupBox
            // 
            _parametersGroupBox.Controls.Add(bookUserControl1);
            _parametersGroupBox.Location = new Point(5, 155);
            _parametersGroupBox.Name = "_parametersGroupBox";
            _parametersGroupBox.Size = new Size(352, 424);
            _parametersGroupBox.TabIndex = 1;
            _parametersGroupBox.TabStop = false;
            _parametersGroupBox.Text = "Параметры карточки";
            // 
            // bookUserControl1
            // 
            bookUserControl1.Location = new Point(0, 22);
            bookUserControl1.Name = "bookUserControl1";
            bookUserControl1.Size = new Size(275, 322);
            bookUserControl1.TabIndex = 0;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(369, 584);
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
        private GroupBox _parametersGroupBox;
        private BookUserControl bookUserControl;
        private BookUserControl bookUserControl1;
    }
}