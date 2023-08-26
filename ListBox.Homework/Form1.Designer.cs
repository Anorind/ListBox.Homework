namespace ListBox.Homework
{
    partial class Form1
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
            listBox1 = new System.Windows.Forms.ListBox();
            LabelFirstName = new Label();
            LabelSecondName = new Label();
            LabelPhoneNumber = new Label();
            LabelEmail = new Label();
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxEmail = new TextBox();
            buttonAddToListBox = new Button();
            buttonDeleteFromListBox = new Button();
            buttonChangeUserFromListBox = new Button();
            buttonSaveToTXT = new Button();
            buttonLoadFromTXT = new Button();
            buttonSaveToXML = new Button();
            buttonLoadFromXML = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(406, 179);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // LabelFirstName
            // 
            LabelFirstName.Location = new Point(424, 12);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(120, 30);
            LabelFirstName.TabIndex = 1;
            LabelFirstName.Text = "Ім'я: ";
            // 
            // LabelSecondName
            // 
            LabelSecondName.Location = new Point(424, 45);
            LabelSecondName.Name = "LabelSecondName";
            LabelSecondName.Size = new Size(120, 30);
            LabelSecondName.TabIndex = 2;
            LabelSecondName.Text = "Прізвище: ";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.Location = new Point(424, 82);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(120, 30);
            LabelPhoneNumber.TabIndex = 3;
            LabelPhoneNumber.Text = "Номер тел.: ";
            // 
            // LabelEmail
            // 
            LabelEmail.Location = new Point(424, 112);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(120, 30);
            LabelEmail.TabIndex = 4;
            LabelEmail.Text = "Емейл: ";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(550, 12);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(234, 31);
            textBoxFirstName.TabIndex = 5;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(550, 45);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(234, 31);
            textBoxSecondName.TabIndex = 6;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(550, 81);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(234, 31);
            textBoxPhoneNumber.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(550, 115);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(234, 31);
            textBoxEmail.TabIndex = 8;
            // 
            // buttonAddToListBox
            // 
            buttonAddToListBox.Location = new Point(550, 161);
            buttonAddToListBox.Name = "buttonAddToListBox";
            buttonAddToListBox.Size = new Size(234, 30);
            buttonAddToListBox.TabIndex = 9;
            buttonAddToListBox.Text = "Додати";
            buttonAddToListBox.UseVisualStyleBackColor = true;
            buttonAddToListBox.Click += buttonAddToListBox_Click;
            // 
            // buttonDeleteFromListBox
            // 
            buttonDeleteFromListBox.Location = new Point(550, 197);
            buttonDeleteFromListBox.Name = "buttonDeleteFromListBox";
            buttonDeleteFromListBox.Size = new Size(234, 30);
            buttonDeleteFromListBox.TabIndex = 10;
            buttonDeleteFromListBox.Text = "Видалити";
            buttonDeleteFromListBox.UseVisualStyleBackColor = true;
            buttonDeleteFromListBox.Click += buttonDeleteFromListBox_Click;
            // 
            // buttonChangeUserFromListBox
            // 
            buttonChangeUserFromListBox.Location = new Point(550, 233);
            buttonChangeUserFromListBox.Name = "buttonChangeUserFromListBox";
            buttonChangeUserFromListBox.Size = new Size(234, 30);
            buttonChangeUserFromListBox.TabIndex = 11;
            buttonChangeUserFromListBox.Text = "Редагувати";
            buttonChangeUserFromListBox.UseVisualStyleBackColor = true;
            buttonChangeUserFromListBox.Click += buttonChangeUserFromListBox_Click;
            // 
            // buttonSaveToTXT
            // 
            buttonSaveToTXT.Location = new Point(12, 200);
            buttonSaveToTXT.Name = "buttonSaveToTXT";
            buttonSaveToTXT.Size = new Size(406, 30);
            buttonSaveToTXT.TabIndex = 12;
            buttonSaveToTXT.Text = "Зберегти в txt";
            buttonSaveToTXT.UseVisualStyleBackColor = true;
            buttonSaveToTXT.Click += buttonSaveToTXT_Click;
            // 
            // buttonLoadFromTXT
            // 
            buttonLoadFromTXT.Location = new Point(12, 230);
            buttonLoadFromTXT.Name = "buttonLoadFromTXT";
            buttonLoadFromTXT.Size = new Size(406, 30);
            buttonLoadFromTXT.TabIndex = 13;
            buttonLoadFromTXT.Text = "Завантажити з файла";
            buttonLoadFromTXT.UseVisualStyleBackColor = true;
            buttonLoadFromTXT.Click += buttonLoadFromTXT_Click;
            // 
            // buttonSaveToXML
            // 
            buttonSaveToXML.Location = new Point(12, 260);
            buttonSaveToXML.Name = "buttonSaveToXML";
            buttonSaveToXML.Size = new Size(406, 30);
            buttonSaveToXML.TabIndex = 14;
            buttonSaveToXML.Text = "Зберегти в xml";
            buttonSaveToXML.UseVisualStyleBackColor = true;
            buttonSaveToXML.Click += buttonSaveToXML_Click;
            // 
            // buttonLoadFromXML
            // 
            buttonLoadFromXML.Location = new Point(12, 290);
            buttonLoadFromXML.Name = "buttonLoadFromXML";
            buttonLoadFromXML.Size = new Size(406, 30);
            buttonLoadFromXML.TabIndex = 15;
            buttonLoadFromXML.Text = "Завантажити з xml";
            buttonLoadFromXML.UseVisualStyleBackColor = true;
            buttonLoadFromXML.Click += buttonLoadFromXML_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 346);
            Controls.Add(listBox1);
            Controls.Add(LabelFirstName);
            Controls.Add(LabelSecondName);
            Controls.Add(LabelPhoneNumber);
            Controls.Add(LabelEmail);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonAddToListBox);
            Controls.Add(buttonDeleteFromListBox);
            Controls.Add(buttonChangeUserFromListBox);
            Controls.Add(buttonSaveToTXT);
            Controls.Add(buttonLoadFromTXT);
            Controls.Add(buttonSaveToXML);
            Controls.Add(buttonLoadFromXML);
            Name = "Form1";
            Text = "Список користувачів";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}