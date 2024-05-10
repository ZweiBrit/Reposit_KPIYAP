using System;
using System.IO;

/// <summary>
/// Программа для чтения чисел из файла, фильтрации и записи результатов в другой файл.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        // Имя входного и выходного файлов
        string inputFile = "f.txt";
        string outputFile = "g.txt";

        try
        {
            // Используем конструкцию using для автоматического закрытия файловых потоков
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string line;
                // Читаем файл построчно
                while ((line = reader.ReadLine()) != null)
                {
                    // Пытаемся преобразовать строку в число
                    if (int.TryParse(line, out int number))
                    {
                        // Проверяем, соответствует ли число условиям
                        if (number % 3 == 0 && number % 7 != 0)
                        {
                            // Записываем число в выходной файл
                            writer.WriteLine(number);
                        }
                    }
                    else
                    {
                        // Если строку не удалось преобразовать в число, выводим ошибку
                        Console.WriteLine($"Ошибка: Не удалось преобразовать строку '{line}' в число.");
                    }
                }
            }

            // Выводим сообщение об успешном завершении программы
            Console.WriteLine("Результат записан в файл g.txt");
        }
        catch (IOException ex)
        {
            // Если возникла ошибка ввода-вывода, выводим сообщение об ошибке
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
