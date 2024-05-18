using System;
using System.Drawing;
using System.Windows.Forms;

namespace TwoFormsApp
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            BackColor = Color.Green; // ������ ���� ���� �����
            FormBorderStyle = FormBorderStyle.None; // ������� ����� � �����
            StartPosition = FormStartPosition.CenterScreen; // ����� ��������� �� ������ ������
            Size = new Size(400, 400); // ������ ������ �����
            Paint += DrawDiamond; // ������������� �� ������� ��������� �����
        }

        private void DrawDiamond(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Green); // ������� ����� �������� �����

            // ������ ���������� ����� �����
            Point[] points = {
                new Point(ClientSize.Width / 2, 0),
                new Point(ClientSize.Width, ClientSize.Height / 2),
                new Point(ClientSize.Width / 2, ClientSize.Height),
                new Point(0, ClientSize.Height / 2)
            };

            // ������ ����
            g.FillPolygon(brush, points);

            // ������ ����� � ������ �����
            Font font = new Font("Arial", 14);
            Brush textBrush = new SolidBrush(Color.Black);
            string text = "GREENPEACE";
            SizeF textSize = g.MeasureString(text, font);
            PointF textLocation = new PointF((ClientSize.Width - textSize.Width) / 2, (ClientSize.Height - textSize.Height) / 2);
            g.DrawString(text, font, textBrush, textLocation);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // ��������� �����
        }
    }
}
