using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) =>
            {
                if (y != 0)
                    return x / y;
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return double.NaN;
                }
            };

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите два числа:");

            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;
                case 2:
                    result = Sub(num1, num2);
                    break;
                case 3:
                    result = Mul(num1, num2);
                    break;
                case 4:
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции!");
                    break;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
