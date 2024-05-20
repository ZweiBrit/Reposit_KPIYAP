using System;
using System.Windows.Forms;

namespace WinButNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load; // ����������� ����� Form1_Load � ������� Load �����
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �������� ���������� ClickButton � ��� ���������� �� �����
            ClickButton clickButton = new ClickButton();
            clickButton.Text = "�������� �� ���� ������";
            clickButton.Location = new System.Drawing.Point(50, 50);
            clickButton.Size = new System.Drawing.Size(100, 100);
            Controls.Add(clickButton);
        }
    }
}
