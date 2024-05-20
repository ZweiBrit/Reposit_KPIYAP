namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);
                double z = double.Parse(textBoxZ.Text);

                double g = Math.Pow(y, x + 1) / (Math.Pow(Math.Abs(y) - 2, 1.0 / 3) + 3) + (Math.Pow(x, y) + 2) / (2 * Math.Abs(x + y)) * Math.Pow(x + 1, -1 / Math.Sin(z));
                double f = y * Math.Sin(z) * g;


                textBoxResult.Text = f.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }
    }
}
