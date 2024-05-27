using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        private float parameterT = 0;
        private const int curveParameterA = 100; // изменение размера и формы кривой

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += OnPaint;

            animationTimer.Interval = 50; // управление скоростью анимации
            animationTimer.Tick += OnTimerTick;
            animationTimer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            parameterT += 0.01f; // управление скоростью анимации
            this.Invalidate(); // Перерисовать форму
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (parameterT >= -1 && parameterT <= 1)
            {
                float x = 3 * curveParameterA * parameterT / (1 + parameterT * parameterT * parameterT) + this.ClientSize.Width / 2;
                float y = 3 * curveParameterA * parameterT * parameterT / (1 + parameterT * parameterT * parameterT) + this.ClientSize.Height / 2;

                e.Graphics.FillEllipse(Brushes.Red, x, y, 10, 10); // Рисуем окружность
            }
        }
    }
}
