namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateP(Func<double, double> f, double x, double y, double z)
        {
            double minVal = Math.Min(f(x), y);
            double maxVal = Math.Max(y, z);
            double p = (minVal - maxVal) / 2;
            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double argP = double.Parse(textBox1.Text);
                double argX = double.Parse(textBox3.Text);

                Func<double, double> function = null;

                if (radioButton1.Checked)
                {
                    function = Math.Sin;
                }
                else if (radioButton2.Checked)
                {
                    function = x => Math.Pow(x, 2);
                }
                else if (radioButton3.Checked)
                {
                    function = x => Math.Pow(Math.E, x);
                }
                else
                {
                    MessageBox.Show("Выберите функцию");
                    return;
                }

                double result = 0;

                if (argX > Math.Abs(argP))
                {
                    result = 2 * Math.Pow(function(argX), 3) + 3 * Math.Pow(argP, 2);
                }
                else if (argX > 3 && argX < Math.Abs(argP))
                {
                    result = Math.Abs(function(argX) - argP);
                }
                else if (argX == Math.Abs(argP))
                {
                    result = Math.Pow(Math.Abs(function(argX) - argP), 2);
                }

                // Вызов функции CalculateP
                double p = CalculateP(function, argX, argP, result);

                richTextBox1.Text += "Результат: " + Convert.ToString(result) + ", p: " + Convert.ToString(p) + Environment.NewLine;
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
