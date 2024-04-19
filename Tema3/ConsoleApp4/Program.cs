using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a1: ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите a2: ");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c2: ");
        double c2 = Convert.ToDouble(Console.ReadLine());

        double result = SubMod(a1, b1) * SubMod(a2, b2, c2);
        Console.WriteLine($"Результат: {result}");
    }

    static double SubMod(double a, double b)
    {
        return Math.Abs(a - b);
    }

    static double SubMod(double a, double b, double c)
    {
        return Math.Abs(a - b - c);
    }
}
