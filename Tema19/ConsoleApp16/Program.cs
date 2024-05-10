using System;
using System.IO;

/// <summary>
/// Класс, представляющий программу для копирования файлов и создания символических ссылок.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        // Получаем список всех файлов в корневой директории "C:\"
        string[] allFiles = Directory.GetFiles("C:\\");

        // Создаем новую директорию "Example_36tp" на диске D:
        string exampleDir = @"D:\Example_36tp";
        Directory.CreateDirectory(exampleDir);

        // Копируем файлы из исходной директории "C:\SourceDirectory" в созданную директорию "Example_36tp"
        string sourceDir = @"C:\SourceDirectory";
        string[] filesToCopy = Directory.GetFiles(sourceDir);
        foreach (string file in filesToCopy)
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(exampleDir, fileName);
            File.Copy(file, destFile, true);
        }

        // Устанавливаем атрибут Hidden для скопированных файлов и создаем символические ссылки на них
        foreach (string file in filesToCopy)
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(exampleDir, fileName);

            File.SetAttributes(destFile, FileAttributes.Hidden);

            string linkFilePath = Path.Combine(exampleDir, "Link_" + fileName);
            CreateSymbolicLink(linkFilePath, destFile, SymbolicLink.File);
        }

        Console.WriteLine("Операции завершены успешно.");
        Console.ReadLine();
    }

    /// <summary>
    /// Метод для создания символической ссылки.
    /// </summary>
    /// <param name="lpSymlinkFileName">Путь к создаваемой ссылке.</param>
    /// <param name="lpTargetFileName">Путь к целевому файлу или директории.</param>
    /// <param name="dwFlags">Тип символической ссылки (файл или директория).</param>
    /// <returns>Возвращает true, если создание ссылки прошло успешно, иначе false.</returns>
    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    public static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);

    /// <summary>
    /// Перечисление, представляющее тип символической ссылки.
    /// </summary>
    public enum SymbolicLink
    {
        /// <summary>
        /// Ссылка на файл.
        /// </summary>
        File = 0,
        /// <summary>
        /// Ссылка на директорию.
        /// </summary>
        Directory = 1
    }
}
