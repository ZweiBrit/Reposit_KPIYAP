using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "input.txt"; 

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не найден.");
            return;
        }

        string fileContent = File.ReadAllText(filePath);

        string sortedContent = SortContent(fileContent);

        Console.WriteLine(sortedContent);
    }

    static string SortContent(string content)
    {
        Queue<char> lettersQueue = new Queue<char>();
        Queue<char> digitsQueue = new Queue<char>();

        foreach (char c in content)
        {
            if (char.IsDigit(c))
            {
                digitsQueue.Enqueue(c);
            }
            else
            {
                lettersQueue.Enqueue(c);
            }
        }

        string sortedContent = "";
        while (lettersQueue.Count > 0)
        {
            sortedContent += lettersQueue.Dequeue();
        }
        while (digitsQueue.Count > 0)
        {
            sortedContent += digitsQueue.Dequeue();
        }

        return sortedContent;
    }
}
