using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFormsApp
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            BackColor = Color.Green; // Задаем цвет фона формы
            FormBorderStyle = FormBorderStyle.None; // Убираем рамку у формы
            StartPosition = FormStartPosition.CenterScreen; // Форма откроется по центру экрана
            Size = new Size(400, 400); // Задаем размер формы
            Paint += DrawDiamond; // Подписываемся на событие отрисовки формы
        }

        private void DrawDiamond(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Green); // Создаем кисть зеленого цвета

            // Задаем координаты точек ромба
            Point[] points = {
                new Point(ClientSize.Width / 2, 0),
                new Point(ClientSize.Width, ClientSize.Height / 2),
                new Point(ClientSize.Width / 2, ClientSize.Height),
                new Point(0, ClientSize.Height / 2)
            };

            // Рисуем ромб
            g.FillPolygon(brush, points);

            // Рисуем текст в центре ромба
            Font font = new Font("Arial", 14);
            Brush textBrush = new SolidBrush(Color.Black);
            string text = "GREENPEACE";
            SizeF textSize = g.MeasureString(text, font);
            PointF textLocation = new PointF((ClientSize.Width - textSize.Width) / 2, (ClientSize.Height - textSize.Height) / 2);
            g.DrawString(text, font, textBrush, textLocation);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму
        }
    }
}
