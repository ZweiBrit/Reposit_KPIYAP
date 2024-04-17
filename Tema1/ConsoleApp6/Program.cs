using System;

class Program
{
    static void Main()
    {
        double A = Math.PI / 6; 
        double B = 2 * Math.PI / 3; 
        int M = 10; 

        double H = (B - A) / M; 

        Console.WriteLine("x\t\tsin(x^2)");
        for (int i = 0; i <= M; i++)
        {
            double x = A + H * i;
            double F = Math.Sin(Math.Pow(x, 2));
            Console.WriteLine($"{x}\t\t{F}");
        }
    }
}
