using System;

public class Task
{
    public int SwapDigits(int number)
    {
        if (number < 1000 || number > 9999)
        {
            throw new ArgumentException("Number must be a four-digit number.");
        }

        int firstTwoDigits = number / 100;
        int lastTwoDigits = number % 100;

        return lastTwoDigits * 100 + firstTwoDigits;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Task task1 = new Task();
        Console.WriteLine(task1.SwapDigits(1234)); // Output: 3412

        Task task2 = new Task();
        Console.WriteLine(task2.SwapDigits(5678)); // Output: 7856

        Task task3 = new Task();
        Console.WriteLine(task3.SwapDigits(9012)); // Output: 1290
    }
}
