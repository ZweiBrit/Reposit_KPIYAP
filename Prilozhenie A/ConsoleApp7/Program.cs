using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a в радианах: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double z1 = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(a), 2));

        double z2 = 2 * Math.Sin(a);

        Console.WriteLine("z2 = " + z2);

        Console.WriteLine("z1 = " + z1);
    }
}
