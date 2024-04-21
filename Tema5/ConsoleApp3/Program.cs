using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размерность матрицы (NxN): ");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];

        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());

        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(a, b + 1);
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());
        double sum = 0;
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] < M)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }
        double average = count > 0 ? sum / count : 0;
        Console.WriteLine($"Среднее арифметическое чисел, меньших {M}: {average}");

        for (int j = 0; j < N; j++)
        {
            int columnSum = 0;
            for (int i = 0; i < N; i++)
            {
                if (matrix[i, j] > 0)
                {
                    columnSum += matrix[i, j];
                }
            }
            Console.WriteLine($"Сумма положительных элементов столбца {j + 1}: {columnSum}");
        }

        Console.ReadLine();
    }
}
