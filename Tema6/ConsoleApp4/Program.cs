using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите фамилию, имя и отчество: ");
        string fullName = Console.ReadLine();
        int identityCode = GetIdentityCode(fullName);
        Console.WriteLine($"Код личности: {identityCode}");
    }

    static int GetIdentityCode(string fullName)
    {
        int sum = fullName.ToUpper()
                          .Where(char.IsLetter)
                          .Sum(c => c - 'А' + 1);

        while (sum > 9)
        {
            sum = sum.ToString().Sum(c => c - '0');
        }

        return sum;
    }
}
