using System;
using System.Threading;
using System.Threading.Tasks;

public class Task
{
    private double _a;

    public Task(double a)
    {
        _a = a;
    }

    public double CalculateZ1()
    {
        Thread.Sleep(1000); // Замедление выполнения задачи на 1 секунду
        return (Math.Sin(2 * _a) + Math.Sin(5 * _a) - Math.Sin(3 * _a)) / (Math.Cos(_a) - Math.Cos(3 * _a) + Math.Cos(5 * _a));
    }

    public double CalculateZ2()
    {
        Thread.Sleep(1000); // Замедление выполнения задачи на 1 секунду
        return 2 * Math.Sin(_a);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Task[] tasks = new Task[2]
        {
            new Task(0.5),
            new Task(1.0)
        };

        // Дождитесь выполнения всех задач
        System.Threading.Tasks.Task[] allTasks = new System.Threading.Tasks.Task[2]
        {
            System.Threading.Tasks.Task.Run(() => Console.WriteLine($"z1 = {tasks[0].CalculateZ1()}")),
            System.Threading.Tasks.Task.Run(() => Console.WriteLine($"z2 = {tasks[1].CalculateZ2()}"))
        };
        System.Threading.Tasks.Task.WaitAll(allTasks);

        // Дождитесь выполнения хотя бы одной задачи
        System.Threading.Tasks.Task[] anyTask = new System.Threading.Tasks.Task[2]
        {
            System.Threading.Tasks.Task.Run(() => Console.WriteLine($"z1 = {tasks[0].CalculateZ1()}")),
            System.Threading.Tasks.Task.Run(() => Console.WriteLine($"z2 = {tasks[1].CalculateZ2()}"))
        };
        System.Threading.Tasks.Task.WaitAny(anyTask);
    }
}
