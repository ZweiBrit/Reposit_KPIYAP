using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer clockTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeClockTimer();
        }

        private void InitializeClockTimer()
        {
            clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            clockTimer.Tick += OnClockTimerTick;
            clockTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int clockRadius = Math.Min(ClientSize.Width, ClientSize.Height) / 2;
            Point clockCenter = new Point(ClientSize.Width / 2, ClientSize.Height / 2);

            DrawClockFace(e.Graphics, clockCenter, clockRadius);
            DrawSecondHand(e.Graphics, clockCenter, clockRadius);
        }

        private void DrawClockFace(Graphics graphics, Point center, int radius)
        {
            graphics.DrawEllipse(Pens.Black, center.X - radius, center.Y - radius, radius * 2, radius * 2);
        }

        private void DrawSecondHand(Graphics graphics, Point center, int radius)
        {
            double angle = DateTime.Now.Second * 6 * Math.PI / 180; // 6 градусов на секунду
            int handLength = (int)(radius * 0.9);
            Point handEnd = new Point(center.X + (int)(handLength * Math.Sin(angle)), center.Y - (int)(handLength * Math.Cos(angle)));
            graphics.DrawLine(Pens.Red, center, handEnd);
        }

        private void OnClockTimerTick(object sender, EventArgs e)
        {
            this.Invalidate(); // Перерисовываем форму
        }
    }
}
