using System;
using System.Windows.Forms;

namespace MatrixSumApp
{
    public partial class MainForm : Form
    {
        private const int Size = 12;
        private int[,] matrix = new int[Size, Size];

        public MainForm()
        {
            InitializeComponent();
            InitializeMatrix();
            DisplayMatrix();
            int sum = CalculateSumAboveDiagonal();
            sumTextBox.Text = sum.ToString();
        }

        private void InitializeMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrix[i, j] = rand.Next(1, 100); // «аполнение матрицы случайными числами от 1 до 99
                }
            }
        }

        private void DisplayMatrix()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrixTextBox.AppendText(matrix[i, j] + "\t");
                }
                matrixTextBox.AppendText(Environment.NewLine);
            }
        }

        private int CalculateSumAboveDiagonal()
        {
            int sum = 0;
            for (int i = 0; i < Size; i++)
            {
                for (int j = i + 1; j < Size; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
    }
}
