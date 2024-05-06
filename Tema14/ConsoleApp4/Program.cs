using System;
using System.Threading;

class Program
{
    static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 

    static void Main(string[] args)
    {
        int numThreads = 4; 
        Thread[] threads = new Thread[numThreads];
        SumThreadResult[] threadResults = new SumThreadResult[numThreads];

        int chunkSize = array.Length / numThreads;


        for (int i = 0; i < numThreads; i++)
        {
            int start = i * chunkSize;
            int end = (i == numThreads - 1) ? array.Length : (i + 1) * chunkSize;

            SumThreadResult threadResult = new SumThreadResult();
            threadResults[i] = threadResult;

            threads[i] = new Thread(() =>
            {
                threadResult.Sum = PartialSum(start, end);
            });

            threads[i].Start();
        }


        foreach (Thread thread in threads)
        {
            thread.Join();
        }

   
        int totalSum = 0;
        foreach (var result in threadResults)
        {
            totalSum += result.Sum;
        }

        Console.WriteLine($"Сумма четных чисел: {totalSum}");

        Console.ReadLine();
    }

    static int PartialSum(int start, int end)
    {
        int sum = 0;
        for (int i = start; i < end; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }
}

class SumThreadResult
{
    public int Sum { get; set; }
}
