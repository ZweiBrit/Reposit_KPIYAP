using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        Console.Write("Введите длину слова (n): ");
        int n = int.Parse(Console.ReadLine());

        string[] words = inputString.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        var filteredWords = words.Where(word => word.Length == n).OrderBy(word => word);

        Console.WriteLine($"Слова длины {n}, в алфавитном порядке:");
        foreach (var word in filteredWords)
        {
            Console.WriteLine(word);
        }

        Console.ReadLine();
    }
}
