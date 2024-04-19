using System;

class FunctionTable
{
    static void Main()
    {
        Console.Write("Введите начальное значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите конечное значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        BuildFunctionTable(a, b, h);
    }

    static void BuildFunctionTable(double a, double b, double h)
    {
        Console.WriteLine(" x | f(x)");
        Console.WriteLine("-----------");
        for (double x = a; x <= b; x += h)
        {
            double fx = Math.Pow(x, 2); 
            Console.WriteLine($"{x,4} | {fx,4}");
        }
    }
}
