using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите сообщение: ");
        string message = Console.ReadLine();

        Console.Write("Введите символ для фильтрации: ");
        char filterChar = char.Parse(Console.ReadLine());

        string[] words = message.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        string filteredMessage = string.Join(" ", words.Where(word => !word.EndsWith(filterChar)));

        Console.WriteLine("Сообщение после фильтрации:");
        Console.WriteLine(filteredMessage);

        Console.ReadLine();
    }
}
