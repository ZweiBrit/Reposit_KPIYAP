using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число A:");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число N:");
        int N = int.Parse(Console.ReadLine());

        Thread thread1 = new Thread(() => SumMethod(A, N));
        Thread thread2 = new Thread(() => MultiplyMethod(A, N));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.ReadLine(); 
    }

    static void SumMethod(int A, int N)
    {
        long result = 0;
        for (int i = 1; i <= N; i++)
        {
            result += A * i;
            Console.WriteLine($"Поток 1: Промежуточный результат на итерации {i}: {result}");
            Thread.Sleep(100);
        }
        Console.WriteLine($"Поток 1: Итоговый результат: {result}");
    }

    static void MultiplyMethod(int A, int N)
    {
        long result = 1;
        for (int i = 1; i <= N; i++)
        {
            result *= A * i;
            Console.WriteLine($"Поток 2: Промежуточный результат на итерации {i}: {result}");
            Thread.Sleep(100); 
        }
        Console.WriteLine($"Поток 2: Итоговый результат: {result}");
    }
}
