using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите вес в фунтах и нажмите <Enter>: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        double weightInKg = weightInPounds * 409.5 / 1000;

        Console.WriteLine(weightInPounds + " фунт(а/ов) — это " + weightInKg + " кг.");
    }
}
