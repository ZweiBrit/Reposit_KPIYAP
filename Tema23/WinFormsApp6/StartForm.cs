using System;
using System.Windows.Forms;

namespace TwoFormsApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // ������������� ����� �� ������������ ������
        }

        private void openSecondFormButton_Click(object sender, EventArgs e)
        {
            // ��� ������� ������ ��������� ������ �����
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }
    }
}
