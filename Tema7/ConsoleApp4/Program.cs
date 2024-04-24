using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Это тестовая строка. Слово: 'a.b.c' - это слово из букв, разделенных точками.";
        string pattern = @"\b([a-zA-Zа-яА-Я]+\.)+[a-zA-Zа-яА-Я]+\b";

        MatchCollection matches = Regex.Matches(input, pattern);
        Console.WriteLine("Слова, состоящие только из букв, разделенных точками:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
