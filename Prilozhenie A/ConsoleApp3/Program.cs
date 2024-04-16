using System;

class Program
{
    static void Main()
    {
        double x = -1;
        double y = 7 * Math.Pow(Math.Atan(Math.Sqrt(Math.Exp(x) + 1 + Math.Abs(x))), 2);
        Console.WriteLine("y = " + y);
    }
}
