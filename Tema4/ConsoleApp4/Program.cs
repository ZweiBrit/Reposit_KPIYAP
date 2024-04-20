using System;

class Program
{
    static void Main()
    {
        byte x = 200;
        byte y = 200;

        try
        {
            byte result = (byte)(x + y);
            Console.WriteLine("Result: {0}", result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Переполнение!");
        }
    }
}
