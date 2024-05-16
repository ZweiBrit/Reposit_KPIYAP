namespace WinFormsApp4
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
            SurnameLabel = new Label();
            NameLabel = new Label();
            MiddleNameLabel = new Label();
            MiddleNameTextBox = new TextBox();
            NameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            SexGroupBox = new GroupBox();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            BirthDateGroupBox = new GroupBox();
            DateBirtPicker = new DateTimePicker();
            LocationLabel = new Label();
            EMailLabel = new Label();
            emailTextBox = new TextBox();
            LocationTextBox = new ComboBox();
            phoneLabel = new Label();
            operatorBox = new ComboBox();
            phoneBox = new TextBox();
            workExpGroupBox = new GroupBox();
            NoWorkRB = new RadioButton();
            From1To5RB = new RadioButton();
            MoreThen10RB = new RadioButton();
            LessThen1RB = new RadioButton();
            From5To9RB = new RadioButton();
            OthersGroupBox = new GroupBox();
            categoryA = new CheckBox();
            categoryB = new CheckBox();
            categoryC = new CheckBox();
            categoryD = new CheckBox();
            driveLicense = new CheckBox();
            haveAuto = new CheckBox();
            driveCategory = new Label();
            salaryGroupBox = new GroupBox();
            ToLabel = new Label();
            FromLabel = new Label();
            ToSalary = new NumericUpDown();
            FromSalary = new NumericUpDown();
            workTimeGroupBox = new GroupBox();
            PartTimeRB = new RadioButton();
            FullTimeRB = new RadioButton();
            CVtextBox = new RichTextBox();
            SaveButton = new Button();
            ClearButton = new Button();
            CancelButton = new Button();
            CVLabel = new Label();
            WorkAtHomeRB = new RadioButton();
            TimeWorkRB = new RadioButton();
            SexGroupBox.SuspendLayout();
            BirthDateGroupBox.SuspendLayout();
            workExpGroupBox.SuspendLayout();
            OthersGroupBox.SuspendLayout();
            salaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FromSalary).BeginInit();
            workTimeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(12, 9);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(76, 20);
            SurnameLabel.TabIndex = 0;
            SurnameLabel.Text = "Фамилия:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 39);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Имя:";
            // 
            // MiddleNameLabel
            // 
            MiddleNameLabel.AutoSize = true;
            MiddleNameLabel.Location = new Point(12, 69);
            MiddleNameLabel.Name = "MiddleNameLabel";
            MiddleNameLabel.Size = new Size(75, 20);
            MiddleNameLabel.TabIndex = 2;
            MiddleNameLabel.Text = "Отчество:";
            // 
            // MiddleNameTextBox
            // 
            MiddleNameTextBox.Location = new Point(93, 66);
            MiddleNameTextBox.Name = "MiddleNameTextBox";
            MiddleNameTextBox.Size = new Size(249, 27);
            MiddleNameTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(94, 36);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(248, 27);
            NameTextBox.TabIndex = 4;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(94, 6);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(248, 27);
            SurnameTextBox.TabIndex = 5;
            // 
            // SexGroupBox
            // 
            SexGroupBox.Controls.Add(FemaleRadioButton);
            SexGroupBox.Controls.Add(MaleRadioButton);
            SexGroupBox.Location = new Point(375, 6);
            SexGroupBox.Name = "SexGroupBox";
            SexGroupBox.Size = new Size(125, 87);
            SexGroupBox.TabIndex = 6;
            SexGroupBox.TabStop = false;
            SexGroupBox.Text = "Пол";
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(6, 29);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(92, 24);
            FemaleRadioButton.TabIndex = 7;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Женский";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Location = new Point(5, 64);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(93, 24);
            MaleRadioButton.TabIndex = 8;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Мужской";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // BirthDateGroupBox
            // 
            BirthDateGroupBox.Controls.Add(DateBirtPicker);
            BirthDateGroupBox.Location = new Point(517, 5);
            BirthDateGroupBox.Name = "BirthDateGroupBox";
            BirthDateGroupBox.Size = new Size(200, 88);
            BirthDateGroupBox.TabIndex = 9;
            BirthDateGroupBox.TabStop = false;
            BirthDateGroupBox.Text = "Дата Рождения:";
            // 
            // DateBirtPicker
            // 
            DateBirtPicker.Location = new Point(6, 48);
            DateBirtPicker.Name = "DateBirtPicker";
            DateBirtPicker.Size = new Size(186, 27);
            DateBirtPicker.TabIndex = 0;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Location = new Point(12, 117);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(148, 20);
            LocationLabel.TabIndex = 10;
            LocationLabel.Text = "Место проживания:";
            // 
            // EMailLabel
            // 
            EMailLabel.AutoSize = true;
            EMailLabel.Location = new Point(12, 148);
            EMailLabel.Name = "EMailLabel";
            EMailLabel.Size = new Size(195, 20);
            EMailLabel.TabIndex = 11;
            EMailLabel.Text = "Адрес электронной почты:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(253, 141);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(464, 27);
            emailTextBox.TabIndex = 12;
            // 
            // LocationTextBox
            // 
            LocationTextBox.FormattingEnabled = true;
            LocationTextBox.Location = new Point(253, 109);
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(464, 28);
            LocationTextBox.TabIndex = 13;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(12, 181);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(159, 20);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Мобильный телефон:";
            // 
            // operatorBox
            // 
            operatorBox.FormattingEnabled = true;
            operatorBox.Location = new Point(253, 173);
            operatorBox.Name = "operatorBox";
            operatorBox.Size = new Size(89, 28);
            operatorBox.TabIndex = 15;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(375, 174);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(342, 27);
            phoneBox.TabIndex = 16;
            // 
            // workExpGroupBox
            // 
            workExpGroupBox.Controls.Add(NoWorkRB);
            workExpGroupBox.Controls.Add(From1To5RB);
            workExpGroupBox.Controls.Add(MoreThen10RB);
            workExpGroupBox.Controls.Add(LessThen1RB);
            workExpGroupBox.Controls.Add(From5To9RB);
            workExpGroupBox.Location = new Point(12, 215);
            workExpGroupBox.Name = "workExpGroupBox";
            workExpGroupBox.Size = new Size(705, 107);
            workExpGroupBox.TabIndex = 17;
            workExpGroupBox.TabStop = false;
            workExpGroupBox.Text = "Опыт работы:";
            // 
            // NoWorkRB
            // 
            NoWorkRB.AutoSize = true;
            NoWorkRB.Location = new Point(6, 23);
            NoWorkRB.Name = "NoWorkRB";
            NoWorkRB.Size = new Size(167, 24);
            NoWorkRB.TabIndex = 4;
            NoWorkRB.TabStop = true;
            NoWorkRB.Text = "Прежде не работал";
            NoWorkRB.UseVisualStyleBackColor = true;
            // 
            // From1To5RB
            // 
            From1To5RB.AutoSize = true;
            From1To5RB.Location = new Point(280, 26);
            From1To5RB.Name = "From1To5RB";
            From1To5RB.Size = new Size(118, 24);
            From1To5RB.TabIndex = 3;
            From1To5RB.TabStop = true;
            From1To5RB.Text = "От 1 до 5 лет";
            From1To5RB.UseVisualStyleBackColor = true;
            // 
            // MoreThen10RB
            // 
            MoreThen10RB.AutoSize = true;
            MoreThen10RB.Location = new Point(533, 23);
            MoreThen10RB.Name = "MoreThen10RB";
            MoreThen10RB.Size = new Size(152, 24);
            MoreThen10RB.TabIndex = 2;
            MoreThen10RB.TabStop = true;
            MoreThen10RB.Text = "От 10 лет и более";
            MoreThen10RB.UseVisualStyleBackColor = true;
            // 
            // LessThen1RB
            // 
            LessThen1RB.AutoSize = true;
            LessThen1RB.Location = new Point(6, 64);
            LessThen1RB.Name = "LessThen1RB";
            LessThen1RB.Size = new Size(135, 24);
            LessThen1RB.TabIndex = 1;
            LessThen1RB.TabStop = true;
            LessThen1RB.Text = "Меньше 1 года";
            LessThen1RB.UseVisualStyleBackColor = true;
            // 
            // From5To9RB
            // 
            From5To9RB.AutoSize = true;
            From5To9RB.Location = new Point(280, 64);
            From5To9RB.Name = "From5To9RB";
            From5To9RB.Size = new Size(118, 24);
            From5To9RB.TabIndex = 0;
            From5To9RB.TabStop = true;
            From5To9RB.Text = "От 5 до 9 лет";
            From5To9RB.UseVisualStyleBackColor = true;
            // 
            // OthersGroupBox
            // 
            OthersGroupBox.Controls.Add(categoryA);
            OthersGroupBox.Controls.Add(categoryB);
            OthersGroupBox.Controls.Add(categoryC);
            OthersGroupBox.Controls.Add(categoryD);
            OthersGroupBox.Controls.Add(driveLicense);
            OthersGroupBox.Controls.Add(haveAuto);
            OthersGroupBox.Controls.Add(driveCategory);
            OthersGroupBox.Location = new Point(12, 335);
            OthersGroupBox.Name = "OthersGroupBox";
            OthersGroupBox.Size = new Size(330, 159);
            OthersGroupBox.TabIndex = 18;
            OthersGroupBox.TabStop = false;
            OthersGroupBox.Text = "Другие Сведения:";
            // 
            // categoryA
            // 
            categoryA.AutoSize = true;
            categoryA.Location = new Point(6, 117);
            categoryA.Name = "categoryA";
            categoryA.Size = new Size(41, 24);
            categoryA.TabIndex = 3;
            categoryA.Text = "A";
            categoryA.UseVisualStyleBackColor = true;
            // 
            // categoryB
            // 
            categoryB.AutoSize = true;
            categoryB.Location = new Point(47, 117);
            categoryB.Name = "categoryB";
            categoryB.Size = new Size(40, 24);
            categoryB.TabIndex = 2;
            categoryB.Text = "B";
            categoryB.UseVisualStyleBackColor = true;
            // 
            // categoryC
            // 
            categoryC.AutoSize = true;
            categoryC.Location = new Point(88, 117);
            categoryC.Name = "categoryC";
            categoryC.Size = new Size(40, 24);
            categoryC.TabIndex = 1;
            categoryC.Text = "C";
            categoryC.UseVisualStyleBackColor = true;
            // 
            // categoryD
            // 
            categoryD.AutoSize = true;
            categoryD.Location = new Point(131, 117);
            categoryD.Name = "categoryD";
            categoryD.Size = new Size(42, 24);
            categoryD.TabIndex = 0;
            categoryD.Text = "D";
            categoryD.UseVisualStyleBackColor = true;
            // 
            // driveLicense
            // 
            driveLicense.AutoSize = true;
            driveLicense.Location = new Point(6, 64);
            driveLicense.Name = "driveLicense";
            driveLicense.Size = new Size(236, 24);
            driveLicense.TabIndex = 19;
            driveLicense.Text = "Водительское удостоверение";
            driveLicense.UseVisualStyleBackColor = true;
            // 
            // haveAuto
            // 
            haveAuto.AutoSize = true;
            haveAuto.Location = new Point(6, 34);
            haveAuto.Name = "haveAuto";
            haveAuto.Size = new Size(189, 24);
            haveAuto.TabIndex = 20;
            haveAuto.Text = "Наличие личного авто";
            haveAuto.UseVisualStyleBackColor = true;
            // 
            // driveCategory
            // 
            driveCategory.AutoSize = true;
            driveCategory.Location = new Point(6, 91);
            driveCategory.Name = "driveCategory";
            driveCategory.Size = new Size(122, 20);
            driveCategory.TabIndex = 4;
            driveCategory.Text = "Категория прав:";
            // 
            // salaryGroupBox
            // 
            salaryGroupBox.Controls.Add(ToLabel);
            salaryGroupBox.Controls.Add(FromLabel);
            salaryGroupBox.Controls.Add(ToSalary);
            salaryGroupBox.Controls.Add(FromSalary);
            salaryGroupBox.Location = new Point(358, 335);
            salaryGroupBox.Name = "salaryGroupBox";
            salaryGroupBox.Size = new Size(359, 79);
            salaryGroupBox.TabIndex = 21;
            salaryGroupBox.TabStop = false;
            salaryGroupBox.Text = "Объем заработной платы:";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(6, 42);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(26, 20);
            ToLabel.TabIndex = 0;
            ToLabel.Text = "От";
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(187, 42);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(28, 20);
            FromLabel.TabIndex = 22;
            FromLabel.Text = "До";
            // 
            // ToSalary
            // 
            ToSalary.Location = new Point(215, 35);
            ToSalary.Name = "ToSalary";
            ToSalary.Size = new Size(138, 27);
            ToSalary.TabIndex = 23;
            // 
            // FromSalary
            // 
            FromSalary.Location = new Point(38, 35);
            FromSalary.Name = "FromSalary";
            FromSalary.Size = new Size(143, 27);
            FromSalary.TabIndex = 24;
            // 
            // workTimeGroupBox
            // 
            workTimeGroupBox.Controls.Add(TimeWorkRB);
            workTimeGroupBox.Controls.Add(PartTimeRB);
            workTimeGroupBox.Controls.Add(FullTimeRB);
            workTimeGroupBox.Controls.Add(WorkAtHomeRB);
            workTimeGroupBox.Location = new Point(358, 420);
            workTimeGroupBox.Name = "workTimeGroupBox";
            workTimeGroupBox.Size = new Size(359, 74);
            workTimeGroupBox.TabIndex = 25;
            workTimeGroupBox.TabStop = false;
            workTimeGroupBox.Text = "Предпочитаемый график работы:";
            // 
            // PartTimeRB
            // 
            PartTimeRB.AutoSize = true;
            PartTimeRB.Location = new Point(176, 20);
            PartTimeRB.Name = "PartTimeRB";
            PartTimeRB.Size = new Size(175, 24);
            PartTimeRB.TabIndex = 36;
            PartTimeRB.TabStop = true;
            PartTimeRB.Text = "Частичная занятость";
            PartTimeRB.UseVisualStyleBackColor = true;
            // 
            // FullTimeRB
            // 
            FullTimeRB.AutoSize = true;
            FullTimeRB.Location = new Point(6, 20);
            FullTimeRB.Name = "FullTimeRB";
            FullTimeRB.Size = new Size(155, 24);
            FullTimeRB.TabIndex = 35;
            FullTimeRB.TabStop = true;
            FullTimeRB.Text = "Полная занятость";
            FullTimeRB.UseVisualStyleBackColor = true;
            // 
            // CVtextBox
            // 
            CVtextBox.Location = new Point(12, 520);
            CVtextBox.Name = "CVtextBox";
            CVtextBox.Size = new Size(705, 149);
            CVtextBox.TabIndex = 4;
            CVtextBox.Text = "";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 675);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(127, 29);
            SaveButton.TabIndex = 26;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(145, 675);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(144, 29);
            ClearButton.TabIndex = 27;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(573, 675);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(144, 29);
            CancelButton.TabIndex = 28;
            CancelButton.Text = "Закрыть";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // CVLabel
            // 
            CVLabel.AutoSize = true;
            CVLabel.Location = new Point(12, 497);
            CVLabel.Name = "CVLabel";
            CVLabel.Size = new Size(127, 20);
            CVLabel.TabIndex = 29;
            CVLabel.Text = "Краткое резюме:";
            // 
            // WorkAtHomeRB
            // 
            WorkAtHomeRB.AutoSize = true;
            WorkAtHomeRB.Location = new Point(6, 44);
            WorkAtHomeRB.Name = "WorkAtHomeRB";
            WorkAtHomeRB.Size = new Size(138, 24);
            WorkAtHomeRB.TabIndex = 34;
            WorkAtHomeRB.TabStop = true;
            WorkAtHomeRB.Text = "Работа на дому";
            WorkAtHomeRB.UseVisualStyleBackColor = true;
            // 
            // TimeWorkRB
            // 
            TimeWorkRB.AutoSize = true;
            TimeWorkRB.Location = new Point(176, 44);
            TimeWorkRB.Name = "TimeWorkRB";
            TimeWorkRB.Size = new Size(163, 24);
            TimeWorkRB.TabIndex = 37;
            TimeWorkRB.TabStop = true;
            TimeWorkRB.Text = "Посменная работа";
            TimeWorkRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 707);
            Controls.Add(MiddleNameTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(CVLabel);
            Controls.Add(CancelButton);
            Controls.Add(ClearButton);
            Controls.Add(SaveButton);
            Controls.Add(CVtextBox);
            Controls.Add(workTimeGroupBox);
            Controls.Add(salaryGroupBox);
            Controls.Add(OthersGroupBox);
            Controls.Add(workExpGroupBox);
            Controls.Add(phoneBox);
            Controls.Add(operatorBox);
            Controls.Add(phoneLabel);
            Controls.Add(LocationTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(EMailLabel);
            Controls.Add(LocationLabel);
            Controls.Add(BirthDateGroupBox);
            Controls.Add(SexGroupBox);
            Controls.Add(MiddleNameLabel);
            Controls.Add(NameLabel);
            Controls.Add(SurnameLabel);
            Name = "Form1";
            Text = "Form1";
            SexGroupBox.ResumeLayout(false);
            SexGroupBox.PerformLayout();
            BirthDateGroupBox.ResumeLayout(false);
            workExpGroupBox.ResumeLayout(false);
            workExpGroupBox.PerformLayout();
            OthersGroupBox.ResumeLayout(false);
            OthersGroupBox.PerformLayout();
            salaryGroupBox.ResumeLayout(false);
            salaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ToSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)FromSalary).EndInit();
            workTimeGroupBox.ResumeLayout(false);
            workTimeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SurnameLabel;
        private Label NameLabel;
        private Label MiddleNameLabel;
        private TextBox MiddleNameTextBox;
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private GroupBox SexGroupBox;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private GroupBox BirthDateGroupBox;
        private DateTimePicker DateBirtPicker;
        private Label LocationLabel;
        private Label EMailLabel;
        private TextBox emailTextBox;
        private ComboBox LocationTextBox;
        private Label phoneLabel;
        private ComboBox operatorBox;
        private TextBox phoneBox;
        private GroupBox workExpGroupBox;
        private RadioButton From1To5RB;
        private RadioButton MoreThen10RB;
        private RadioButton LessThen1RB;
        private RadioButton From5To9RB;
        private RadioButton NoWorkRB;
        private GroupBox OthersGroupBox;
        private CheckBox categoryA;
        private CheckBox categoryB;
        private CheckBox categoryC;
        private CheckBox categoryD;
        private Label driveCategory;
        private CheckBox driveLicense;
        private CheckBox haveAuto;
        private GroupBox salaryGroupBox;
        private Label ToLabel;
        private Label FromLabel;
        private NumericUpDown ToSalary;
        private NumericUpDown FromSalary;
        private GroupBox workTimeGroupBox;
        private RichTextBox CVtextBox;
        private Button SaveButton;
        private Button ClearButton;
        private Button CancelButton;
        private Label CVLabel;
        private RadioButton PartTimeRB;
        private RadioButton FullTimeRB;
        private RadioButton WorkAtHomeRB;
        private RadioButton TimeWorkRB;
    }
}
