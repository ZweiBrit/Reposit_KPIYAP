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

                double y1 = x * Math.Cos(x);
                double y2 = 12 / (3 * x - 3);


                if (x < 0 || x >= 1)
                {
                    throw new ArgumentOutOfRangeException("Значение x должно быть в диапазоне (0, 1)");
                }

                Console.WriteLine($"Значение выражения y1 = x * cos(x) при x = {x} равно {y1}");
                Console.WriteLine($"Значение выражения y2 = 12 / (3x - 3) при x = {x} равно {y2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат числа!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
