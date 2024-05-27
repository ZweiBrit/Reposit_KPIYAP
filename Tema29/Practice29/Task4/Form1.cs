using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        private Bitmap skyImage, planeImage;
        private Graphics graphicsSurface;
        private int planeSpeedX;
        private Rectangle planeRectangle;
        private bool isDemoMode = true;
        private Random randomGenerator;
        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            LoadResources();
            InitializeFormSettings();
            InitializeAnimationSettings();
        }

        private void LoadResources()
        {
            try
            {
                skyImage = new Bitmap("D:/Practic/Tema29/Practice29/source/sky.bmp");
                planeImage = new Bitmap("D:/Practic/Tema29/Practice29/source/plane.bmp");
                this.BackgroundImage = new Bitmap("D:/Practic/Tema29/Practice29/source/sky.bmp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            planeImage.MakeTransparent();
        }

        private void InitializeFormSettings()
        {
            this.ClientSize = new Size(BackgroundImage.Width, BackgroundImage.Height);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            graphicsSurface = Graphics.FromImage(BackgroundImage);
        }

        private void InitializeAnimationSettings()
        {
            randomGenerator = new Random();
            planeRectangle = new Rectangle(-40, 20 + randomGenerator.Next(20), planeImage.Width, planeImage.Height);
            planeSpeedX = 2;

            animationTimer.Interval = 20;
            animationTimer.Tick += OnAnimationTick;
            animationTimer.Start();
        }

        private void OnAnimationTick(object sender, EventArgs e)
        {
            graphicsSurface.DrawImage(skyImage, new Point(0, 0));

            if (planeRectangle.X < this.ClientRectangle.Width)
            {
                planeRectangle.X += planeSpeedX;
            }
            else
            {
                ResetPlanePosition();
            }

            graphicsSurface.DrawImage(planeImage, planeRectangle.X, planeRectangle.Y);

            if (!isDemoMode)
            {
                this.Invalidate(planeRectangle);
            }
            else
            {
                Rectangle updateRegion = new Rectangle(20, 20, skyImage.Width - 40, skyImage.Height - 40);
                graphicsSurface.DrawRectangle(Pens.Black, updateRegion.X, updateRegion.Y, updateRegion.Width - 1, updateRegion.Height - 1);
                this.Invalidate(updateRegion);
            }
        }

        private void ResetPlanePosition()
        {
            planeRectangle.X = -40;
            planeRectangle.Y = 20 + randomGenerator.Next(this.ClientSize.Height - 40 - planeImage.Height);
            planeSpeedX = 2 + randomGenerator.Next(4);
        }
    }
}
