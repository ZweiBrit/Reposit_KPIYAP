using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        string n = Console.ReadLine();

        Console.Write("Введите цифру k: ");
        char k = Console.ReadKey().KeyChar;

        int count = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == k)
            {
                count++;
            }
        }

        Console.WriteLine("\nЦифра " + k + " встречается в числе " + n + " " + count + " раз.");
    }
}
