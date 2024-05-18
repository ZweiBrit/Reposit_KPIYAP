using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Violet;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Сделаем форму овальной
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(0, 0, this.Width, this.Height));
            this.Region = new Region(path);

            // Добавляем обработчик события клика на форму
            this.Click += Form1_Click;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            g.DrawEllipse(pen, rect);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Oval Form";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Close(); // Добавляем закрытие формы при клике на неё
        }
    }
}
