using System.Windows;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonRun.Click += Button_Click;
            buttonAbout.Click += ButtonAbout_Click;
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"О программе: {this.Title}";
            AboutApp about = new AboutApp(info);
            about.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxEnterName.Text;
            textBlockHello.Text = $"Привет, {name}!";
        }
    }
}
