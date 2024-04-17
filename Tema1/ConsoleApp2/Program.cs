using System;

class Program
{
    static void Main()
    {
        int number = 123; 
        string numberStr = number.ToString();

        int firstDigit = int.Parse(numberStr[0].ToString());
        int lastDigit = int.Parse(numberStr[numberStr.Length - 1].ToString());

        if (firstDigit > lastDigit)
        {
            Console.WriteLine("Первая цифра больше последней.");
        }
        else if (firstDigit < lastDigit)
        {
            Console.WriteLine("Последняя цифра больше первой.");
        }
        else
        {
            Console.WriteLine("Первая и последняя цифры равны.");
        }
    }
}
