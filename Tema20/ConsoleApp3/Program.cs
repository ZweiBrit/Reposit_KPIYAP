using System;
using System.Threading.Tasks;

public class Task
{
    private int _number;

    public Task(int number)
    {
        if (number < 100 || number > 999)
        {
            throw new ArgumentException("Number must be a three-digit number.");
        }

        _number = number;
    }

    public int CalculateProduct()
    {
        int secondDigit = (_number / 10) % 10;
        int lastDigit = _number % 10;

        return secondDigit * lastDigit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Task task1 = new Task(123);
        System.Threading.Tasks.Task<int> t1 = System.Threading.Tasks.Task.Run(() => task1.CalculateProduct());

        System.Threading.Tasks.Task t2 = t1.ContinueWith(t => Console.WriteLine($"The product of the second and last digit is: {t.Result}"));

        t2.Wait();
    }
}
