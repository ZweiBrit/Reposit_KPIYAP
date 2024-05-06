using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(CalculateSum);
        Thread thread2 = new Thread(CalculateSum);

        DateTime startTime = DateTime.Now;

        thread1.Start();
        thread2.Start();

        thread1.Join(); 
        thread2.Join();

        DateTime endTime = DateTime.Now;

        TimeSpan duration = endTime - startTime;
        Console.WriteLine($"Время выполнения первого потока: {duration.TotalMilliseconds} мс");

        Console.ReadLine();
    }

    static void CalculateSum()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Thread.Sleep(100); 
        }
        Console.WriteLine($"Сумма чисел от 1 до 10: {sum}");
    }
}
