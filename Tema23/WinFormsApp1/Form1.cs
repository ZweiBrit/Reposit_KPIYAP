using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox textBoxText;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private List<Label> labels;

        public Form1()
        {
            InitializeComponent();
            labels = new List<Label>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddControls();
        }

        private void AddControls()
        {
            Label labelText = new Label
            {
                Text = "Текст метки:",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(100, 20)
            };

            textBoxText = new TextBox
            {
                Location = new System.Drawing.Point(130, 20),
                Size = new System.Drawing.Size(100, 20)
            };

            Label labelX = new Label
            {
                Text = "X:",
                Location = new System.Drawing.Point(20, 50),
                Size = new System.Drawing.Size(20, 20)
            };

            textBoxX = new TextBox
            {
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(50, 20)
            };

            Label labelY = new Label
            {
                Text = "Y:",
                Location = new System.Drawing.Point(110, 50),
                Size = new System.Drawing.Size(20, 20)
            };

            textBoxY = new TextBox
            {
                Location = new System.Drawing.Point(140, 50),
                Size = new System.Drawing.Size(50, 20)
            };

            Label labelWidth = new Label
            {
                Text = "Ширина:",
                Location = new System.Drawing.Point(200, 50),
                Size = new System.Drawing.Size(80, 20)
            };

            textBoxWidth = new TextBox
            {
                Location = new System.Drawing.Point(300, 50),
                Size = new System.Drawing.Size(50, 20)
            };

            Label labelHeight = new Label
            {
                Text = "Высота:",
                Location = new System.Drawing.Point(400, 50),
                Size = new System.Drawing.Size(80, 20)
            };

            textBoxHeight = new TextBox
            {
                Location = new System.Drawing.Point(500, 50),
                Size = new System.Drawing.Size(50, 20)
            };

            Button button = new Button
            {
                Text = "Добавить",
                Location = new System.Drawing.Point(20, 80),
                Size = new System.Drawing.Size(100, 30)
            };

            button.Click += ButtonAddLabel_Click;

            Controls.Add(labelText);
            Controls.Add(textBoxText);
            Controls.Add(labelX);
            Controls.Add(textBoxX);
            Controls.Add(labelY);
            Controls.Add(textBoxY);
            Controls.Add(labelWidth);
            Controls.Add(textBoxWidth);
            Controls.Add(labelHeight);
            Controls.Add(textBoxHeight);
            Controls.Add(button);
        }

        private void ButtonAddLabel_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            string labelText = textBoxText.Text;
            int x = int.Parse(textBoxX.Text);
            int y = int.Parse(textBoxY.Text);
            int width = int.Parse(textBoxWidth.Text);
            int height = int.Parse(textBoxHeight.Text);

            // Создаем новую метку
            Label newLabel = new Label
            {
                Text = labelText,
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(width, height),
                BorderStyle = BorderStyle.FixedSingle
            };

            labels.Add(newLabel);
            Controls.Add(newLabel);

            // Обновляем заголовок формы
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            int smallLabelsCount = labels.Count(l => l.Width < 50 && l.Height < 50);
            int largeLabelsCount = labels.Count(l => l.Width >= 50 || l.Height >= 50);

            this.Text = $"Маленькие метки: {smallLabelsCount}, Большие метки: {largeLabelsCount}";
        }
    }
}
