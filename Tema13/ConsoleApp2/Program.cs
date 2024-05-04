using System;

public delegate void MessageDelegate();

class Program
{
    static void Message1()
    {
        Console.WriteLine("Это сообщение 1");
    }

    static void Message2()
    {
        try
        {
            Console.WriteLine("Это сообщение 2");
            throw new Exception("Произошла исключительная ситуация в методе 2");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Message3()
    {
        Console.WriteLine("Это сообщение 3");
    }

    static void ExecuteMessage(MessageDelegate messageDelegate)
    {
        messageDelegate();
    }

    static void Main(string[] args)
    {
        MessageDelegate messageDelegate1 = Message1;
        MessageDelegate messageDelegate2 = Message2;
        MessageDelegate messageDelegate3 = Message3;

        ExecuteMessage(messageDelegate1);
        ExecuteMessage(messageDelegate2);
        ExecuteMessage(messageDelegate3);
    }
}
