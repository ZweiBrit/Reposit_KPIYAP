using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Мой номер телефона - 1234567890. Мой адрес - улица 7-я, дом 10.";
        string pattern = @"\b\w*\d\w*\b";

        MatchCollection matches = Regex.Matches(input, pattern);
        Console.WriteLine("Слова, содержащие хотя бы одну цифру:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
