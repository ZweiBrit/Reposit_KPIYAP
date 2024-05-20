namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_MouseClick(object sender, MouseEventArgs e)
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
        }
    }
}
