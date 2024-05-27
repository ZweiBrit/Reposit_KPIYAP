namespace Task1
{
    public partial class Form1 : Form
    {
        private double centerX, centerY, endX, endY;
        private int angle = 90;
        private readonly Pen drawingPen = new Pen(Color.DarkRed, 2);
        private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            updateTimer.Interval = 1000;
            updateTimer.Start();
            this.Paint += new PaintEventHandler(OnPaint);
            updateTimer.Tick += new EventHandler(OnTimerTick);
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            angle -= 6;
            if (angle >= 360) angle -= 360;
            double radians = angle * Math.PI / 180;
            centerX = ClientSize.Width / 2;
            centerY = ClientSize.Height / 2;
            endX = centerX + (int)(100 * Math.Cos(radians));
            endY = centerY - (int)(100 * Math.Sin(radians));
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawLine(drawingPen, (float)centerX, (float)centerY, (float)endX, (float)endY);
        }
    }
}
