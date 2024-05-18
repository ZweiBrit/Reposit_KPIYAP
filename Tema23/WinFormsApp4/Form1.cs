using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private TextBox textBoxType;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button addButton;

        // Делегат для обработки события удаления элемента управления
        private delegate void ControlRemovedEventHandler(Control control);

        public Form1()
        {
            InitializeComponent();
            InitializeUI(); // Добавляем вызов метода инициализации пользовательского интерфейса
        }

        private void InitializeComponent()
        {
            this.textBoxType = new TextBox();
            this.textBoxX = new TextBox();
            this.textBoxY = new TextBox();
            this.addButton = new Button();
            this.SuspendLayout();
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new Point(10, 10);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new Size(100, 20);
            this.textBoxType.TabIndex = 0;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new Point(10, 40);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new Size(100, 20);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new Point(10, 70);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new Size(100, 20);
            this.textBoxY.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new Point(10, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Control";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxType);
            this.Name = "Form1";
            this.Text = "Dynamic Controls";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void InitializeUI()
        {
            // Добавляем обработчик события MouseHover для всех элементов управления на форме
            foreach (Control control in Controls)
            {
                control.MouseHover += Control_MouseHover;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            string controlType = textBoxType.Text;
            int x, y;

            // Проверяем корректность ввода координат
            if (!int.TryParse(textBoxX.Text, out x) || !int.TryParse(textBoxY.Text, out y))
            {
                MessageBox.Show("Please enter valid integer values for X and Y coordinates.");
                return;
            }

            // Создаем новый элемент управления в зависимости от типа
            switch (controlType)
            {
                case "К":
                    Button button = new Button();
                    button.Text = "New Button";
                    button.Location = new Point(x, y);
                    Controls.Add(button);
                    // Добавляем обработчик события для новой кнопки
                    button.MouseHover += (s, args) => RemoveControl((Control)s);
                    break;
                case "П":
                    TextBox textBox = new TextBox();
                    textBox.Text = "New TextBox";
                    textBox.Location = new Point(x, y);
                    Controls.Add(textBox);
                    // Добавляем обработчик события для нового текстового поля
                    textBox.MouseHover += (s, args) => RemoveControl((Control)s);
                    break;
                case "М":
                    Label label = new Label();
                    label.Text = "New Label";
                    label.Location = new Point(x, y);
                    Controls.Add(label);
                    // Добавляем обработчик события для новой метки
                    label.MouseHover += (s, args) => RemoveControl((Control)s);
                    break;
                default:
                    MessageBox.Show("Invalid control type. Please enter 'К', 'П', or 'М'.");
                    break;
            }
        }

        // Метод для удаления элемента управления
        private void RemoveControl(Control control)
        {
            Controls.Remove(control);
        }

        private void Control_MouseHover(object sender, EventArgs e)
        {
            // Проверяем, был ли элемент управления добавлен динамически
            if (sender is Control dynamicControl && !Controls.Contains(dynamicControl))
            {
                // Если да, то удаляем его
                Controls.Remove(dynamicControl);
            }
        }
    }
}
