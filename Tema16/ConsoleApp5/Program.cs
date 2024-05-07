using System;
using System.IO;
using System.Linq;

class Program
{
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
