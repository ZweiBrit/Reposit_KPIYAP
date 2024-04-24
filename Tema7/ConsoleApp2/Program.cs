using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Антон работает в Альфа-банке. Его друг Алексей тоже там работает.";
        string pattern = @"\b[AaАа]\w*\b";

        MatchCollection matches = Regex.Matches(input, pattern);
        Console.WriteLine("Слова, начинающиеся с буквы 'A' или 'а':");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
