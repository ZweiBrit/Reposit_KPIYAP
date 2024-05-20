using System;
using System.Windows.Forms;

namespace WinButNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load; // Привязываем метод Form1_Load к событию Load формы
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создание экземпляра ClickButton и его добавление на форму
            ClickButton clickButton = new ClickButton();
            clickButton.Text = "НАКЛИКАЙ НА МЕНЯ СИЛЬНО";
            clickButton.Location = new System.Drawing.Point(50, 50);
            clickButton.Size = new System.Drawing.Size(100, 100);
            Controls.Add(clickButton);
        }
    }
}
