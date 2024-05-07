using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "f.txt";
        string outputFile = "g.txt";

        try
        {
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int number))
                    {
                        if (number % 3 == 0 && number % 7 != 0)
                        {
                            writer.WriteLine(number);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка: Не удалось преобразовать строку '{line}' в число.");
                    }
                }
            }

            Console.WriteLine("Результат записан в файл g.txt");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
