using System;

/// <summary>
/// Программа для вычисления результата выражения, используя функцию SubMod.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
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

    /// <summary>
    /// Возвращает модуль разности между двумя числами.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Модуль разности между a и b.</returns>
    static double SubMod(double a, double b)
    {
        return Math.Abs(a - b);
    }

    /// <summary>
    /// Возвращает модуль разности между тремя числами.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <param name="c">Третье число.</param>
    /// <returns>Модуль разности между a, b и c.</returns>
    static double SubMod(double a, double b, double c)
    {
        return Math.Abs(a - b - c);
    }
}
