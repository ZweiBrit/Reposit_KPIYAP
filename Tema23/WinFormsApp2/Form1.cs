using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Chart chart;
        private TextBox textBoxStep;
        private Button buttonPlot;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            // Создаем и настраиваем элемент управления Chart
            chart = new Chart
            {
                Location = new System.Drawing.Point(20, 60),
                Size = new System.Drawing.Size(600, 400)
            };

            ChartArea chartArea = new ChartArea
            {
                Name = "ChartArea1"
            };
            chart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Series1",
                ChartType = SeriesChartType.Line,
                ChartArea = "ChartArea1"
            };
            chart.Series.Add(series);

            Controls.Add(chart);

            // Добавляем текстовое поле для ввода шага
            Label labelStep = new Label
            {
                Text = "Шаг h:",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(50, 20)
            };

            textBoxStep = new TextBox
            {
                Location = new System.Drawing.Point(80, 20),
                Size = new System.Drawing.Size(100, 20)
            };

            // Добавляем кнопку для построения графика
            buttonPlot = new Button
            {
                Text = "Построить график",
                Location = new System.Drawing.Point(200, 20),
                Size = new System.Drawing.Size(120, 30)
            };

            buttonPlot.Click += ButtonPlot_Click;

            Controls.Add(labelStep);
            Controls.Add(textBoxStep);
            Controls.Add(buttonPlot);
        }

        private void ButtonPlot_Click(object sender, EventArgs e)
        {
            // Получаем значение шага из текстового поля
            if (!double.TryParse(textBoxStep.Text, out double h) || h <= 0)
            {
                MessageBox.Show("Введите корректное значение шага h (положительное число).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Очищаем предыдущие данные
            chart.Series["Series1"].Points.Clear();

            // Генерируем данные и добавляем их на график
            for (double x = 0; x <= 10; x += h)
            {
                double y = Math.Exp(x);
                chart.Series["Series1"].Points.AddXY(x, y);
            }
        }
    }
}
