using System;
using System.Windows.Forms;

namespace TwoFormsApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // Разворачиваем форму на максимальный размер
        }

        private void openSecondFormButton_Click(object sender, EventArgs e)
        {
            // При нажатии кнопки открываем вторую форму
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }
    }
}
