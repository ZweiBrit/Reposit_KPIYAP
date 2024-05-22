using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ExponentialGraph
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlotButton_Click(object sender, RoutedEventArgs e)
        {
            double startX, endX, step;
            if (!double.TryParse(StartXTextBox.Text, out startX) ||
                !double.TryParse(EndXTextBox.Text, out endX) ||
                !double.TryParse(StepTextBox.Text, out step) ||
                step <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения.");
                return;
            }

            DrawGraph(startX, endX, step);
        }

        private void DrawGraph(double startX, double endX, double step)
        {
            GraphCanvas.Children.Clear();
            double canvasWidth = GraphCanvas.ActualWidth;
            double canvasHeight = GraphCanvas.ActualHeight;
            double xRange = endX - startX;
            double maxY = Math.Exp(endX);
            double minY = Math.Exp(startX);

            for (double x = startX; x <= endX; x += step)
            {
                double y = Math.Exp(x);
                double canvasX = (x - startX) / xRange * canvasWidth;
                double canvasY = canvasHeight - ((y - minY) / (maxY - minY) * canvasHeight);

                Ellipse point = new Ellipse
                {
                    Width = 3,
                    Height = 3,
                    Fill = Brushes.Red
                };
                Canvas.SetLeft(point, canvasX);
                Canvas.SetTop(point, canvasY);
                GraphCanvas.Children.Add(point);
            }
        }
    }
}
