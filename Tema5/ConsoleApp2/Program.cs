using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел в последовательности: ");
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i + 1}-е число: ");
            sequence[i] = int.Parse(Console.ReadLine());
        }

        bool evenAfterOdd = false;
        for (int i = 0; i < n - 1; i++)
        {
            if (sequence[i] % 2 != 0 && sequence[i + 1] % 2 == 0)
            {
                evenAfterOdd = true;
                break;
            }
        }

        if (evenAfterOdd)
        {
     
            Console.WriteLine("Положительные числа в обратном порядке:");
            for (int i = n - 1; i >= 0; i--)
            {
                if (sequence[i] > 0)
                    Console.Write(sequence[i] + " ");
            }
        }
        else
        {
     
            Console.WriteLine("Отрицательные числа в обратном порядке:");
            for (int i = n - 1; i >= 0; i--)
            {
                if (sequence[i] < 0)
                    Console.Write(sequence[i] + " ");
            }
        }

        Console.ReadLine();
    }
}
