using System;

public class EventClass
{
    public delegate void MyDelegate();
    public event MyDelegate MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke();
    }
}

public class Observer1
{
    public void OnEvent()
    {
        Console.WriteLine("Observer1: Событие произошло");
    }
}

public class Observer2
{
    public void OnEvent()
    {
        Console.WriteLine("Observer2: Событие произошло");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EventClass eventClass = new EventClass();
        Observer1 observer1 = new Observer1();
        Observer2 observer2 = new Observer2();

        eventClass.MyEvent += observer1.OnEvent;
        eventClass.MyEvent += observer1.OnEvent;
        eventClass.MyEvent += observer2.OnEvent;

        Console.WriteLine("Вызов события с тремя обработчиками:");
        eventClass.RaiseEvent();

        eventClass.MyEvent -= observer1.OnEvent;

        Console.WriteLine("\nВызов события с двумя обработчиками:");
        eventClass.RaiseEvent();
    }
}
