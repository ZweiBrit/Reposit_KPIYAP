using System;
using System.Windows.Forms;

public class EquationForm : Form
{
    private TextBox xInput, yInput, zInput, gOutput;
    private Label xLabel, yLabel, zLabel, fLabel, gLabel;
    private Button calculateButton;
    private ComboBox functionSelect;

    public EquationForm()
    {
        xLabel = new Label { Text = "Введите x:", Top = 10, Left = 10 };
        xInput = new TextBox { Top = 10, Left = 120 };

        yLabel = new Label { Text = "Введите y:", Top = 40, Left = 10 };
        yInput = new TextBox { Top = 40, Left = 120 };

        zLabel = new Label { Text = "Введите z:", Top = 70, Left = 10 };
        zInput = new TextBox { Top = 70, Left = 120 };

        fLabel = new Label { Text = "Выберите f(x):", Top = 100, Left = 10 };
        functionSelect = new ComboBox { Top = 100, Left = 120 };
        functionSelect.Items.AddRange(new string[] { "sh(x)", "x^2", "e^x" });

        gLabel = new Label { Text = "Результат (g):", Top = 130, Left = 10 };
        gOutput = new TextBox { Top = 130, Left = 120, ReadOnly = true };

        calculateButton = new Button { Text = "Вычислить", Top = 160, Left = 10 };
        calculateButton.Click += CalculateButton_Click;

        Controls.Add(xLabel);
        Controls.Add(xInput);
        Controls.Add(yLabel);
        Controls.Add(yInput);
        Controls.Add(zLabel);
        Controls.Add(zInput);
        Controls.Add(fLabel);
        Controls.Add(functionSelect);
        Controls.Add(gLabel);
        Controls.Add(gOutput);
        Controls.Add(calculateButton);
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        double x = double.Parse(xInput.Text);
        double y = double.Parse(yInput.Text);
        double z = double.Parse(zInput.Text);

        Func<double, double> f = null;
        switch (functionSelect.SelectedItem.ToString())
        {
            case "sh(x)":
                f = x => Math.Sinh(x);
                break;
            case "x^2":
                f = x => Math.Pow(x, 2);
                break;
            case "e^x":
                f = x => Math.Exp(x);
                break;
        }

        double g = (Math.Pow(y, x + 1)) / (3 * Math.Sqrt(Math.Abs(y - 2)) + 3) + (x + y) / (2 * Math.Abs(x + y)) * Math.Pow((x + 1), -1) / Math.Sin(z);

        gOutput.Text = g.ToString();
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new EquationForm());
    }
}
