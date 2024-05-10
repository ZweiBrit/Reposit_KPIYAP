using System;

namespace CalculatorApp
{
    /// <summary>
    /// Программа-калькулятор, выполняющая различные арифметические операции.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            // Функции для выполнения операций
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

            // Вывод меню операций
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            // Считывание выбора операции
            int choice = Convert.ToInt32(Console.ReadLine());

            // Ввод двух чисел
            Console.WriteLine("Введите два числа:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            // Выбор операции и выполнение вычислений
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

            // Вывод результата
            Console.WriteLine("Результат: " + result);
        }
    }
}
