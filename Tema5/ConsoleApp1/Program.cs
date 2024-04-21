using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] arr = Enumerable.Range(1, random.Next(20)).Select(r => random.Next(1, 100)).ToArray();

        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(" ", arr));

        arr = arr.Select((a, i) => i % 2 == 0 ? 0 : a).ToArray();

        Console.WriteLine("Новый массив:");
        Console.WriteLine(string.Join(" ", arr));

        Console.ReadLine();
    }
}
