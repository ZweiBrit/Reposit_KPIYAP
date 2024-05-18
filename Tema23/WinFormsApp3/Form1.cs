using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawOrange(e.Graphics);
        }

        private void DrawOrange(Graphics g)
        {
            // ������ �����
            Color orangeColor = Color.Orange;
            Color darkOrangeColor = Color.DarkOrange;
            Color leafGreenColor = Color.Green;

            // ������� �����
            SolidBrush orangeBrush = new SolidBrush(orangeColor);
            SolidBrush darkOrangeBrush = new SolidBrush(darkOrangeColor);
            SolidBrush leafGreenBrush = new SolidBrush(leafGreenColor);

            // ������� �����
            Pen orangePen = new Pen(orangeColor, 2);
            Pen darkOrangePen = new Pen(darkOrangeColor, 2);
            Pen leafGreenPen = new Pen(leafGreenColor, 2);

            // ������ ���� ���������
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = 100;
            g.FillEllipse(orangeBrush, centerX - radius, centerY - radius, radius * 2, radius * 2);
            g.DrawEllipse(orangePen, centerX - radius, centerY - radius, radius * 2, radius * 2);

            // ������ ������ ���������
            Point[] leaf1 = {
                new Point(centerX, centerY - radius),
                new Point(centerX + 40, centerY - radius - 40),
                new Point(centerX + 20, centerY - radius)
            };
            g.FillPolygon(leafGreenBrush, leaf1);
            g.DrawPolygon(leafGreenPen, leaf1);

            Point[] leaf2 = {
                new Point(centerX, centerY - radius),
                new Point(centerX - 40, centerY - radius - 40),
                new Point(centerX - 20, centerY - radius)
            };
            g.FillPolygon(leafGreenBrush, leaf2);
            g.DrawPolygon(leafGreenPen, leaf2);

            // ������ �������� ��������� (����)
            g.DrawArc(darkOrangePen, centerX - radius + 10, centerY - radius + 10, radius * 2 - 20, radius * 2 - 20, 45, 180);
            g.DrawArc(darkOrangePen, centerX - radius + 20, centerY - radius + 20, radius * 2 - 40, radius * 2 - 40, 225, 180);

            // ����������� �������
            orangeBrush.Dispose();
            darkOrangeBrush.Dispose();
            leafGreenBrush.Dispose();
            orangePen.Dispose();
            darkOrangePen.Dispose();
            leafGreenPen.Dispose();
        }
    }
}
