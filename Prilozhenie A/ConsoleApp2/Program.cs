using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        string number = Console.ReadLine();

        if (number.Length != 4)
        {
            Console.WriteLine("Введенное число не является четырехзначным.");
            return;
        }

        string swappedNumber = number.Substring(2, 2) + number.Substring(0, 2);

        Console.WriteLine("Число после перестановки двух первых и двух последних цифр: " + swappedNumber);
    }
}
