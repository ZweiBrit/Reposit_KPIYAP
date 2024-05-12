using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 16, 34, 87, 23 };
        int threshold = 13;

        Parallel.ForEach(numbers, (number, state) =>
        {
            int sum = 0;
            long product = 1;

            for (int i = 0; i <= number; i++)
            {
                sum += i;
                product *= i;

                if (sum > threshold)
                {
                    Console.WriteLine($"Execution stopped: the sum exceeded the threshold of {threshold}.");
                    state.Stop();
                    return;
                }
            }

            Console.WriteLine($"For N = {number}: Sum = {sum}, Product = {product}");
        });
    }
}
