using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = A; i <= B; i++)
        {
            sum += i * i;
        }

        Console.WriteLine("Сумма квадратов всех целых чисел от A до B включительно: " + sum);
    }
}
