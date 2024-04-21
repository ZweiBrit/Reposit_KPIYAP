using System;

class Program
{
    static double CalculateF(int n)
    {
        if (n == 0)
        {
            return 1; 
        }
        else
        {
           
            double factorialN = CalculateFactorial(n);
            return (1 + factorialN) / (2 + factorialN);
        }
    }

    static double CalculateFactorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * CalculateFactorial(num - 1);
        }
    }

    static void Main()
    {
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        double result = CalculateF(n);
        Console.WriteLine($"f({n}) = {result}");

        Console.ReadLine();
    }
}
