using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Привет, мир! Это тестовая строка. Слово: '!!!' - это слово из символов пунктуации.";
        string pattern = @"(^|\s)[\p{P}]+(\s|$)";

        MatchCollection matches = Regex.Matches(input, pattern);
        Console.WriteLine("Слова, состоящие только из символов пунктуации:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.Trim());
        }
    }
}
