using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        private PictureBox rocketPictureBox;
        private System.Windows.Forms.Timer animationTimer;
        private Button launchButton;
        private int rocketYPosition;

        public Form1()
        {
            InitializeComponent();
            InitializeRocket();
            InitializeLaunchButton();
            InitializeAnimationTimer();
        }

        private void InitializeRocket()
        {
            rocketPictureBox = new PictureBox
            {
                Image = Image.FromFile("D:/Practic/Tema29/Practice29/source/Rocket.png"), // путь к изображению ракеты
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height)
            };
            this.Controls.Add(rocketPictureBox);
        }

        private void InitializeLaunchButton()
        {
            launchButton = new Button
            {
                Text = "Запуск!",
                BackColor = Color.Red,
                Location = new Point(this.ClientSize.Width / 2 - 200, this.ClientSize.Height - 50)
            };
            launchButton.Click += OnLaunchButtonClick;
            this.Controls.Add(launchButton);
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new System.Windows.Forms.Timer { Interval = 50 };
            animationTimer.Tick += OnAnimationTimerTick;
        }

        private void OnLaunchButtonClick(object sender, EventArgs e)
        {
            rocketYPosition = this.ClientSize.Height;
            animationTimer.Start();
        }

        private void OnAnimationTimerTick(object sender, EventArgs e)
        {
            rocketYPosition -= 5;
            rocketPictureBox.Location = new Point(rocketPictureBox.Location.X, rocketYPosition);

            if (rocketPictureBox.Location.Y < 0)
            {
                animationTimer.Stop();
                MessageBox.Show("Ракета запущена!");
            }
        }
    }
}
