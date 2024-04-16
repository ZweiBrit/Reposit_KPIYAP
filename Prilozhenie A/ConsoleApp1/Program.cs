using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        int diff = num1 - num2;
        int prod = num1 * num2;

        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Разность: " + diff);
        Console.WriteLine("Произведение: " + prod);
    }
}
