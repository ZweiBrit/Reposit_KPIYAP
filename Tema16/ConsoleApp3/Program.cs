using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "text_file.txt";

        // Создаем текстовый файл и записываем в него 5 строк различной длины
        WriteTextToFile(fileName);

        // a) Выводим весь файл на экран
        Console.WriteLine("Содержимое файла:");
        DisplayFileContent(fileName);

        // b) Подсчитываем количество строк
        int lineCount = CountLines(fileName);
        Console.WriteLine($"Количество строк в файле: {lineCount}");

        // c) Подсчитываем количество символов в каждой строке
        Console.WriteLine("Количество символов в каждой строке:");
        CountCharactersInEachLine(fileName);

        // d) Удаляем последнюю строку из файла и записываем результат в новый файл
        string newFileName = "new_text_file.txt";
        RemoveLastLine(fileName, newFileName);
        Console.WriteLine($"Последняя строка удалена из файла '{fileName}'. Результат записан в файл '{newFileName}'.");

        // e) Выводим на экран строки с s1 по s2
        int s1 = 2; // начиная со второй строки (индексация с нуля)
        int s2 = 4; // заканчивая четвертой строкой
        Console.WriteLine($"Строки с {s1 + 1} по {s2 + 1}:");
        DisplayLinesInRange(fileName, s1, s2);

        // f) Находим длину самой длинной строки и выводим ее на экран
        int maxLength = FindLongestLine(fileName);
        Console.WriteLine($"Длина самой длинной строки: {maxLength}");

        // g) Выводим на экран все строки, начинающиеся с заданной буквы
        char startingLetter = 'T';
        Console.WriteLine($"Строки, начинающиеся с буквы '{startingLetter}':");
        DisplayLinesStartingWithLetter(fileName, startingLetter);

        // h) Переписываем строки файла в другой файл в обратном порядке
        string reversedFileName = "reversed_text_file.txt";
        ReverseWriteToFile(fileName, reversedFileName);
        Console.WriteLine($"Строки файла '{fileName}' переписаны в файл '{reversedFileName}' в обратном порядке.");
    }

    // Создание текстового файла и запись в него 5 строк различной длины
    static void WriteTextToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Short line");
            writer.WriteLine("A bit longer line");
            writer.WriteLine("This line is even longer");
            writer.WriteLine("Another long line with some additional text");
            writer.WriteLine("This is the longest line among all lines in this file");
        }
    }

    // Вывод содержимого файла на экран
    static void DisplayFileContent(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }

    // Подсчет количества строк в файле
    static int CountLines(string fileName)
    {
        return File.ReadAllLines(fileName).Length;
    }

    // Подсчет количества символов в каждой строке файла
    static void CountCharactersInEachLine(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine($"Строка \"{line}\" содержит {line.Length} символов.");
        }
    }

    // Удаление последней строки из файла и запись результата в новый файл
    static void RemoveLastLine(string fileName, string newFileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        File.WriteAllLines(newFileName, lines.Take(lines.Length - 1));
    }

    // Вывод строк с s1 по s2 в файле
    static void DisplayLinesInRange(string fileName, int s1, int s2)
    {
        string[] lines = File.ReadAllLines(fileName);
        for (int i = s1; i <= s2; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }

    // Поиск длины самой длинной строки в файле
    static int FindLongestLine(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        int maxLength = lines.Max(line => line.Length);
        return maxLength;
    }

    // Вывод строк файла, начинающихся с заданной буквы
    static void DisplayLinesStartingWithLetter(string fileName, char letter)
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            if (line.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(line);
            }
        }
    }

    // Переписывание строк файла в другой файл в обратном порядке
    static void ReverseWriteToFile(string fileName, string reversedFileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        Array.Reverse(lines);
        File.WriteAllLines(reversedFileName, lines);
    }
}
