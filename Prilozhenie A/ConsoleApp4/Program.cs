using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину первого основания трапеции (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину второго основания трапеции (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите высоту трапеции (h): ");
        double h = Convert.ToDouble(Console.ReadLine());

        double S = 0.5 * (a + b) * h;

        Console.WriteLine("Площадь трапеции: " + S);
    }
}
