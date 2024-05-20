using System.Windows.Forms;

namespace Task4
{
    public partial class Form4 : Form
    {
        private HelpProvider helpProvider;
        private Button helpButton;
        private ToolTip toolTip;

        public Form4()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;
            HelpButton = true;

            helpProvider = new HelpProvider();
            helpProvider.HelpNamespace = @"D:\Practic\Tema24\WinFormsApp3\bin\Debug\net8.0-windows\helpfortask4.txt"; 

            // Создайте кнопку для вызова справки
            helpButton = new Button();
            helpButton.Text = "Help";
            helpButton.Click += new EventHandler(HelpButton_Click);
            this.Controls.Add(helpButton);

            helpProvider.SetHelpString(Name, "Введите ваше имя");
            helpProvider.SetHelpString(Surname, "Введите вашу фамилию");
            helpProvider.SetHelpString(MiddleName, "Введите ваше отчество");
            helpProvider.SetHelpString(Email, "Введите ваш адрес электронной почты");
            helpProvider.SetHelpString(PhoneNumber, "Введите ваш номер телефона");
            helpProvider.SetHelpString(LocationCity, "Выберите ваш город проживания");
            helpProvider.SetHelpString(CallOperator, "Выберите вашего оператора связи");
            helpProvider.SetHelpString(Male, "Выберите ваш пол");
            helpProvider.SetHelpString(Female, "Выберите ваш пол");
            helpProvider.SetHelpString(NotWorking, "Выберите ваш опыт работы");
            helpProvider.SetHelpString(LessThanOneYear, "Выберите ваш опыт работы");
            helpProvider.SetHelpString(FromOneToFiveYears, "Выберите ваш опыт работы");
            helpProvider.SetHelpString(FromFiveToNineYears, "Выберите ваш опыт работы");
            helpProvider.SetHelpString(MoreThanTenYears, "Выберите ваш опыт работы");
            helpProvider.SetHelpString(DriverCategoryA, "Выберите категории водительских прав");
            helpProvider.SetHelpString(DriverCategoryB, "Выберите категории водительских прав");
            helpProvider.SetHelpString(DriverCategoryC, "Выберите категории водительских прав");
            helpProvider.SetHelpString(DriverCategoryD, "Выберите категории водительских прав");
            helpProvider.SetHelpString(FullTime, "Выберите ваш график работы");
            helpProvider.SetHelpString(PartTime, "Выберите ваш график работы");
            helpProvider.SetHelpString(WorkAtHome, "Выберите ваш график работы");
            helpProvider.SetHelpString(TimeWork, "Выберите ваш график работы");
            helpProvider.SetHelpString(MinSalary, "Введите минимальную зарплату");
            helpProvider.SetHelpString(MaxSalary, "Введите максимальную зарплату");


            toolTip = new ToolTip();
            toolTip.SetToolTip(Name, "Введите ваше имя");
            toolTip.SetToolTip(Surname, "Введите вашу фамилию");
            toolTip.SetToolTip(MiddleName, "Введите ваше отчество");
            toolTip.SetToolTip(Email, "Введите ваш адрес электронной почты");
            toolTip.SetToolTip(PhoneNumber, "Введите ваш номер телефона");
            toolTip.SetToolTip(LocationCity, "Выберите ваш город проживания");
            toolTip.SetToolTip(CallOperator, "Выберите вашего оператора связи");
            toolTip.SetToolTip(Male, "Выберите ваш пол");
            toolTip.SetToolTip(Female, "Выберите ваш пол");
            toolTip.SetToolTip(NotWorking, "Выберите ваш опыт работы");
            toolTip.SetToolTip(LessThanOneYear, "Выберите ваш опыт работы");
            toolTip.SetToolTip(FromOneToFiveYears, "Выберите ваш опыт работы");
            toolTip.SetToolTip(FromFiveToNineYears, "Выберите ваш опыт работы");
            toolTip.SetToolTip(MoreThanTenYears, "Выберите ваш опыт работы");
            toolTip.SetToolTip(DriverCategoryA, "Выберите категории водительских прав");
            toolTip.SetToolTip(DriverCategoryB, "Выберите категории водительских прав");
            toolTip.SetToolTip(DriverCategoryC, "Выберите категории водительских прав");
            toolTip.SetToolTip(DriverCategoryD, "Выберите категории водительских прав");
            toolTip.SetToolTip(FullTime, "Выберите ваш график работы");
            toolTip.SetToolTip(PartTime, "Выберите ваш график работы");
            toolTip.SetToolTip(WorkAtHome, "Выберите ваш график работы");
            toolTip.SetToolTip(TimeWork, "Выберите ваш график работы");
            toolTip.SetToolTip(MinSalary, "Введите минимальную зарплату");
            toolTip.SetToolTip(MaxSalary, "Введите максимальную зарплату");
        }

        // Обработчик события нажатия на кнопку справки
        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider.HelpNamespace);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { Name, Surname, MiddleName, Email, PhoneNumber };
            ComboBox[] comboBoxes = { LocationCity, CallOperator };
            RadioButton[] radioButtons = { Male, Female };
            RadioButton[] workExpRadioButtons = { NotWorking, LessThanOneYear, FromOneToFiveYears, FromFiveToNineYears, MoreThanTenYears };
            CheckBox[] categoryCheckboxes = { DriverCategoryA, DriverCategoryB, DriverCategoryC, DriverCategoryD };
            RadioButton[] workGraphicRadioButtons = { FullTime, PartTime, WorkAtHome, TimeWork };
            NumericUpDown[] numericUpDowns = { MinSalary, MaxSalary };

            string GetSelectedRadioButtonText(RadioButton[] radioButtons)
            {
                foreach (RadioButton radioButton in radioButtons)
                {
                    if (radioButton.Checked)
                    {
                        return radioButton.Text;
                    }
                }
                return "";
            }

            string GetSelectedCheckBoxText(CheckBox[] checkBoxes)
            {
                string result = "";
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        result += checkBox.Text;
                    }
                }
                return result;
            }

            string[] textBoxValues = textBoxes.Select(textBox => textBox.Text).ToArray();

            string[] comboBoxValues = comboBoxes.Select(comboBox => comboBox.Text).ToArray();

            string sex = GetSelectedRadioButtonText(radioButtons);
            string dateOfBirth = DateBirth.Text;

            string workExp = GetSelectedRadioButtonText(workExpRadioButtons);
            if (workExp == "")
            {
                MessageBox.Show("Не выбран опыт работы");
                return;
            }

            string driveCategory = GetSelectedCheckBoxText(categoryCheckboxes);

            string workGraphic = GetSelectedRadioButtonText(workGraphicRadioButtons);
            if (workGraphic == "")
            {
                MessageBox.Show("Выберите график работы");
                return;
            }

            string salaryFrom = Convert.ToString(MinSalary.Value);
            string salaryTo = Convert.ToString(MaxSalary.Value);

            AboutMe.AppendText($"Фамилия: {textBoxValues[1]}\n");
            AboutMe.AppendText($"Имя: {textBoxValues[0]}\n");
            AboutMe.AppendText($"Отчество: {textBoxValues[2]}\n");
            AboutMe.AppendText($"Пол: {sex}\n");
            AboutMe.AppendText($"Дата рождения: {dateOfBirth}\n");
            AboutMe.AppendText($"Город проживания: {comboBoxValues[0]}\n");
            AboutMe.AppendText($"Электронная почта: {textBoxValues[3]}\n");
            AboutMe.AppendText($"Телефон: {textBoxValues[4]}\n");
            AboutMe.AppendText($"Оператор связи: {comboBoxValues[1]}\n");
            AboutMe.AppendText($"Опыт работы: {workExp}\n");
            AboutMe.AppendText($"Личный автомобиль: {(HaveAPersonalCar.Checked ? "Да" : "Нет")}\n");
            AboutMe.AppendText($"Водительское удостоверение: {(DriverLicense.Checked ? "Да" : "Нет")}\n");
            AboutMe.AppendText($"Категории водительских прав: {driveCategory}\n");
            AboutMe.AppendText($"Зарплата от: {salaryFrom}\n");
            AboutMe.AppendText($"Зарплата до: {salaryTo}\n");
            AboutMe.AppendText($"График работы: {workGraphic}\n");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { Name, Surname, MiddleName, Email, PhoneNumber };
            ComboBox[] comboBoxes = { LocationCity, CallOperator };
            RadioButton[] radioButtons = { Male, Female };
            RadioButton[] workExpRadioButtons = { NotWorking, LessThanOneYear, FromOneToFiveYears, FromFiveToNineYears, MoreThanTenYears };
            CheckBox[] categoryCheckboxes = { DriverCategoryA, DriverCategoryB, DriverCategoryC, DriverCategoryD };
            RadioButton[] workGraphicRadioButtons = { FullTime, PartTime, WorkAtHome, TimeWork };
            NumericUpDown[] numericUpDowns = { MinSalary, MaxSalary };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = -1;
            }

            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.Checked = false;
            }

            foreach (CheckBox checkBox in categoryCheckboxes)
            {
                checkBox.Checked = false;
            }

            foreach (NumericUpDown numericUpDown in numericUpDowns)
            {
                numericUpDown.Value = numericUpDown.Minimum;
            }

            AboutMe.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
