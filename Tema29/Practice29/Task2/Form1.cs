namespace Task2
{
    public partial class Form1 : Form
    {
        // переменные для работы с баннером
        private Bitmap bannerImage;
        // область вывода баннера
        private Rectangle bannerRect;
        // таймер для обновления баннера
        private System.Windows.Forms.Timer bannerTimer = new System.Windows.Forms.Timer();
        // расстояние между баннерами
        private const int bannerSpacing = 50;

        public Form1()
        {
            InitializeComponent();
            LoadBanner("D:/Practic/Tema29/Practice29/source/baner.png");

            // определение области вывода баннера
            bannerRect = new Rectangle(0, 0, bannerImage.Width, bannerImage.Height);

            // настройка таймера
            bannerTimer.Interval = 50;
            bannerTimer.Tick += OnBannerTimerTick;

            // включение двойной буферизации
            this.DoubleBuffered = true;

            // подписываемся на события
            this.Load += OnFormLoad;
            this.Paint += OnFormPaint;
            this.MouseMove += OnFormMouseMove;
        }

        private void LoadBanner(string path)
        {
            try
            {
                // попытка загрузить баннер из файла
                bannerImage = new Bitmap(path);
            }
            catch (Exception ex)
            {
                // если произошла ошибка, выводим сообщение
                MessageBox.Show("Ошибка загрузки баннера: " + ex.ToString(), "Ошибка");
                this.Close();
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            bannerTimer.Start();
        }

        private void OnBannerTimerTick(object sender, EventArgs e)
        {
            if (bannerImage == null) return;

            bannerRect.X -= 1;
            if (Math.Abs(bannerRect.X) > bannerRect.Width + bannerSpacing)
                bannerRect.X += bannerRect.Width + bannerSpacing;

            Invalidate(); // запрос на перерисовку формы
        }

        private void OnFormPaint(object sender, PaintEventArgs e)
        {
            if (bannerImage == null) return;

            Graphics graphics = e.Graphics;

            for (int i = 0; i <= this.ClientSize.Width / (bannerRect.Width + bannerSpacing) + 1; i++)
            {
                graphics.DrawImage(bannerImage, bannerRect.X + i * (bannerRect.Width + bannerSpacing), bannerRect.Y);
            }
        }

        private void OnFormMouseMove(object sender, MouseEventArgs e)
        {
            bool isMouseOverBanner = (e.Y < bannerRect.Y + bannerRect.Height) && (e.Y > bannerRect.Y);

            if (isMouseOverBanner && !bannerTimer.Enabled)
            {
                bannerTimer.Enabled = true;
            }
            else if (!isMouseOverBanner && bannerTimer.Enabled)
            {
                bannerTimer.Enabled = false;
            }
        }
    }
}
