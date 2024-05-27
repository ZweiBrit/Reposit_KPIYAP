namespace Task2
{
    public partial class Form1 : Form
    {
        // ���������� ��� ������ � ��������
        private Bitmap bannerImage;
        // ������� ������ �������
        private Rectangle bannerRect;
        // ������ ��� ���������� �������
        private System.Windows.Forms.Timer bannerTimer = new System.Windows.Forms.Timer();
        // ���������� ����� ���������
        private const int bannerSpacing = 50;

        public Form1()
        {
            InitializeComponent();
            LoadBanner("D:/Practic/Tema29/Practice29/source/baner.png");

            // ����������� ������� ������ �������
            bannerRect = new Rectangle(0, 0, bannerImage.Width, bannerImage.Height);

            // ��������� �������
            bannerTimer.Interval = 50;
            bannerTimer.Tick += OnBannerTimerTick;

            // ��������� ������� �����������
            this.DoubleBuffered = true;

            // ������������� �� �������
            this.Load += OnFormLoad;
            this.Paint += OnFormPaint;
            this.MouseMove += OnFormMouseMove;
        }

        private void LoadBanner(string path)
        {
            try
            {
                // ������� ��������� ������ �� �����
                bannerImage = new Bitmap(path);
            }
            catch (Exception ex)
            {
                // ���� ��������� ������, ������� ���������
                MessageBox.Show("������ �������� �������: " + ex.ToString(), "������");
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

            Invalidate(); // ������ �� ����������� �����
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
