using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        string number = Console.ReadLine();

        if (number.Length != 3)
        {
            Console.WriteLine("Введенное число не является трехзначным.");
            return;
        }

        int secondDigit = Convert.ToInt32(number[1].ToString());
        int lastDigit = Convert.ToInt32(number[2].ToString());

        int product = secondDigit * lastDigit;

        Console.WriteLine("Произведение второй и последней цифры: " + product);
    }
}
