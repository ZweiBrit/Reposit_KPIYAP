using System;

namespace ExpressionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение x:");
                double x = double.Parse(Console.ReadLine());

                if (double.IsNaN(x))
                {
                    throw new ArgumentException("Неверный формат числа!");
                }

                double y1 = Math.Atan(x) / (x - 3);
                double y2 = Math.Log(x) + (5 * x - 3) / (x - 1);

                Console.WriteLine($"Значение выражения y1 = arctg(x) / (x - 3) при x = {x} равно {y1}");
                Console.WriteLine($"Значение выражения y2 = ln(x) + (5x - 3) / (x - 1) при x = {x} равно {y2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат числа!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
