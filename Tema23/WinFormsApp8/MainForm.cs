using System;
using System.Linq;
using System.Windows.Forms;

namespace ArrayReplacementApp
{
    public partial class MainForm : Form
    {
        private int[] array = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10, 11, -12, 13, -14 };

        public MainForm()
        {
            InitializeComponent();
            DisplayArray(array, originalArrayTextBox);
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            int[] modifiedArray = (int[])array.Clone();
            for (int i = 0; i < modifiedArray.Length; i++)
            {
                if (modifiedArray[i] < 0)
                {
                    modifiedArray[i] = 3;
                }
            }
            DisplayArray(modifiedArray, modifiedArrayTextBox);
        }

        private void DisplayArray(int[] array, TextBox textBox)
        {
            textBox.Text = string.Join(", ", array);
        }
    }
}
