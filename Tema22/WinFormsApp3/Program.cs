using System;
using System.Windows.Forms;

public class MyForm : Form
{
    private TextBox inputTextBox;
    private TextBox outputTextBox;
    private Button calculateButton;
    private RadioButton shRadioButton;
    private RadioButton squareRadioButton;
    private RadioButton expRadioButton;

    public MyForm()
    {
        // Создание и настройка элементов формы
        inputTextBox = new TextBox { Location = new Point(10, 10), Size = new Size(100, 30) };
        outputTextBox = new TextBox { Location = new Point(10, 50), Size = new Size(100, 30), ReadOnly = true };
        calculateButton = new Button { Text = "Вычислить", Location = new Point(10, 90), Size = new Size(100, 30) };
        shRadioButton = new RadioButton { Text = "sh(x)", Location = new Point(120, 10), Size = new Size(60, 30) };
        squareRadioButton = new RadioButton { Text = "x^2", Location = new Point(120, 50), Size = new Size(60, 30) };
        expRadioButton = new RadioButton { Text = "e^x", Location = new Point(120, 90), Size = new Size(60, 30) };

        // Обработчик события нажатия на кнопку
        calculateButton.Click += (sender, e) =>
        {
            double x = double.Parse(inputTextBox.Text);
            double result = 0.0;

            if (shRadioButton.Checked)
                result = Math.Sinh(x);
            else if (squareRadioButton.Checked)
                result = Math.Pow(x, 2);
            else if (expRadioButton.Checked)
                result = Math.Exp(x);

            outputTextBox.Text = result.ToString();
        };

        // Добавление элементов на форму
        this.Controls.Add(inputTextBox);
        this.Controls.Add(outputTextBox);
        this.Controls.Add(calculateButton);
        this.Controls.Add(shRadioButton);
        this.Controls.Add(squareRadioButton);
        this.Controls.Add(expRadioButton);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MyForm());
    }
}
