using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double x, y;
        for (x = 1; x <= 5; x += 0.1)
        {
            y = Math.Log(x) + Math.Pow(Math.Cos(x * x), 2);
            y = Math.Round(y, 1); 
            Console.WriteLine($"При x = {Math.Round(x, 1)}, y = {y}");
        }

        x = Math.PI;
        y = Math.Pow(Math.Sin(x), 2); 
        Console.WriteLine($"При x = {Math.Round(x, 1)}, y = {y}");
    }
}
