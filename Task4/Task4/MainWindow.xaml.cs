using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DynamicButtonsApp
{
    public partial class MainWindow : Window
    {
        private Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            // Создание новой кнопки
            Button newButton = new Button
            {
                Content = "Hover over me",
                Width = 100,
                Height = 30,
                Margin = new Thickness(10)
            };

            // Установка случайного местоположения для новой кнопки
            newButton.HorizontalAlignment = HorizontalAlignment.Left;
            newButton.VerticalAlignment = VerticalAlignment.Top;
            newButton.Margin = new Thickness(random.Next((int)(MainGrid.ActualWidth - newButton.Width)),
                                             random.Next((int)(MainGrid.ActualHeight - newButton.Height)),
                                             0, 0);

            // Добавление обработчиков событий
            newButton.MouseEnter += Button_MouseEnter;
            newButton.Click += Button_Click;

            // Добавление новой кнопки на Grid
            MainGrid.Children.Add(newButton);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                MainGrid.Children.Remove(clickedButton);
            }
        }
    }
}
