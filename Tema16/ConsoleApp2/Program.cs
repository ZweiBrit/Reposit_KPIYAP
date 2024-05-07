using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string folderPath = "New_folder";

        try
        {

            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Папка успешно создана.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании папки: {ex.Message}");
        }
    }
}
