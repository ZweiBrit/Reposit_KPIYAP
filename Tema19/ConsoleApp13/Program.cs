using System;
using System.IO;

/// <summary>
/// Программа для замены символов в строках файла.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        // Имя входного и выходного файлов
        string inputFileName = "input.txt";
        string outputFileName = "output.txt";

        // Переписывание строк с заменой символов и запись результата в новый файл
        ReverseSymbols(inputFileName, outputFileName);
        Console.WriteLine($"Строки файла '{inputFileName}' переписаны с заменой символов и записаны в файл '{outputFileName}'.");
    }

    /// <summary>
    /// Переписывает строки из входного файла с заменой символов и записывает результат в выходной файл.
    /// </summary>
    /// <param name="inputFileName">Имя входного файла.</param>
    /// <param name="outputFileName">Имя выходного файла.</param>
    static void ReverseSymbols(string inputFileName, string outputFileName)
    {
        using (StreamReader reader = new StreamReader(inputFileName))
        using (StreamWriter writer = new StreamWriter(outputFileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string reversedLine = ReverseCharacters(line);
                writer.WriteLine(reversedLine);
            }
        }
    }

    /// <summary>
    /// Заменяет символы '0' на '1' и символы '1' на '0' в строке.
    /// </summary>
    /// <param name="line">Строка, в которой нужно заменить символы.</param>
    /// <returns>Строка с замененными символами.</returns>
    static string ReverseCharacters(string line)
    {
        char[] characters = line.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i] == '0')
                characters[i] = '1';
            else if (characters[i] == '1')
                characters[i] = '0';
        }
        return new string(characters);
    }
}
