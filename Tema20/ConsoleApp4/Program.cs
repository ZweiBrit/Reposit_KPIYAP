using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int A = -5;
        int B = 16;

        Parallel.For(A, B + 1, i =>
        {
            double x = i;
            double result = Math.Sin(Math.Pow(x, 2));
            Console.WriteLine($"f({x}) = {result}");
        });
    }
}
