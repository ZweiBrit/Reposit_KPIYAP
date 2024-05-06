using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(CountNumbers);
        Thread thread2 = new Thread(CountNumbers);
        Thread thread3 = new Thread(CountNumbers);

        thread1.Name = "Thread 1";
        thread2.Name = "Thread 2";
        thread3.Name = "Thread 3";

        thread1.Start(0);
        thread2.Start(10); 
        thread3.Start(20); 
    }

    static void CountNumbers(object start)
    {
        int num = (int)start;

        for (int i = 0; i < 10; i++)
        {
            lock (typeof(Program))
            {
                Console.WriteLine(Thread.CurrentThread.Name + ": " + num);
                num++;
            }

            Thread.Sleep(100); 
        }
    }
}
