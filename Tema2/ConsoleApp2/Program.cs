using System;
using System.IO;

public class File
{
    public string Name { get; private set; }
    public DateTime CreationDate { get; private set; }
    public long Length { get; private set; }

    public File(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Имя файла не может быть пустым.");
        }

        if (!System.IO.File.Exists(name))
        {
            throw new FileNotFoundException("Файл не найден.");
        }

        FileInfo fileInfo = new FileInfo(name);
        Name = fileInfo.Name;
        CreationDate = fileInfo.CreationTime;
        Length = fileInfo.Length;
    }

    public void AppendText(string text)
    {
        using (StreamWriter sw = System.IO.File.AppendText(Name))
        {
            sw.Write(text);
        }

        Length = new FileInfo(Name).Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        File file = new File("test.txt");
        Console.WriteLine($"Имя файла: {file.Name}");
        Console.WriteLine($"Дата создания: {file.CreationDate}");
        Console.WriteLine($"Длина файла: {file.Length}");

        file.AppendText("\nДобавленный текст");
        Console.WriteLine($"Длина файла после добавления текста: {file.Length}");
    }
}
