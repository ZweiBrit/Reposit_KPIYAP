using System;
using System.IO;

/// <summary>
/// Программа для создания новой папки.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        // Путь к новой папке
        string folderPath = "New_folder";

        try
        {
            // Создаем новую папку
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Папка успешно создана.");
        }
        catch (Exception ex)
        {
            // Выводим сообщение об ошибке, если что-то пошло не так
            Console.WriteLine($"Ошибка при создании папки: {ex.Message}");
        }
    }
}
