using System;
using System.IO;
using System.Linq;

/// <summary>
/// Программа для работы с числами в файле.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        double[] numbers = { 2.5, -1.3, 4.7, -0.8, 3.2, 1.6, -5.9, 7.1 };

        string fileName = "numbers.txt";

        WriteNumbersToFile(fileName, numbers);

        double threshold = 2.0;
        Console.WriteLine($"Числа файла меньше {threshold}:");
        DisplayNumbersLessThan(fileName, threshold);

        Console.WriteLine("Положительные числа файла:");
        DisplayPositiveNumbers(fileName);

        double average = CalculateEvenPositionAverage(fileName);
        Console.WriteLine($"Среднее арифметическое чисел на четных позициях файла: {average}");
    }

    /// <summary>
    /// Записывает числа в файл.
    /// </summary>
    /// <param name="fileName">Имя файла.</param>
    /// <param name="numbers">Массив чисел для записи в файл.</param>
    static void WriteNumbersToFile(string fileName, double[] numbers)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (double number in numbers)
            {
                writer.WriteLine(number);
            }
        }
    }

    /// <summary>
    /// Выводит на экран числа из файла, которые меньше заданного порога.
    /// </summary>
    /// <param name="fileName">Имя файла.</param>
    /// <param name="threshold">Порог для сравнения чисел.</param>
    static void DisplayNumbersLessThan(string fileName, double threshold)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                double number = double.Parse(line);
                if (number < threshold)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }

    /// <summary>
    /// Выводит на экран положительные числа из файла.
    /// </summary>
    /// <param name="fileName">Имя файла.</param>
    static void DisplayPositiveNumbers(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                double number = double.Parse(line);
                if (number > 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }

    /// <summary>
    /// Вычисляет среднее арифметическое чисел на четных позициях в файле.
    /// </summary>
    /// <param name="fileName">Имя файла.</param>
    /// <returns>Среднее арифметическое чисел на четных позициях.</returns>
    static double CalculateEvenPositionAverage(string fileName)
    {
        double sum = 0;
        int count = 0;

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            int position = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (position % 2 == 0)
                {
                    double number = double.Parse(line);
                    sum += number;
                    count++;
                }
                position++;
            }
        }

        if (count == 0)
        {
            return 0;
        }
        else
        {
            return sum / count;
        }
    }
}
