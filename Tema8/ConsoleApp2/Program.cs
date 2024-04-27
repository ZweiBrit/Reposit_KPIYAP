using System;

public enum Position
{
    Director = 160, 
    Manager = 180, 
    Engineer = 200, 
    Clerk = 220, 
    Janitor = 240 
}

class Program
{
    static void Main(string[] args)
    {
        Position director = Position.Director;
        Position manager = Position.Manager;
        Position engineer = Position.Engineer;
        Position clerk = Position.Clerk;
        Position janitor = Position.Janitor;

        Console.WriteLine($"Директор должен отработать {director} часов в месяц.");
        Console.WriteLine($"Менеджер должен отработать {manager} часов в месяц.");
        Console.WriteLine($"Инженер должен отработать {engineer} часов в месяц.");
        Console.WriteLine($"Клерк должен отработать {clerk} часов в месяц.");
        Console.WriteLine($"Уборщик должен отработать {janitor} часов в месяц.");
    }
}
