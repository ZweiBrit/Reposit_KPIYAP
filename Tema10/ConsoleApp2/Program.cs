using System;

class A
{
    protected int a = 5;
    protected int b = 10;

    public int C
    {
        get { return a + b; }
    }
}

class B : A
{
    private int d = 20;

    public B() { }

    public B(int a, int b, int d)
    {
        this.a = a;
        this.b = b;
        this.d = d;
    }


    public int C2
    {
        get
        {
            if (a > b)
                return a + b + d;
            else
                return a - b + d;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        A objA = new A();

        B objBDefault = new B();

        B objBCustom = new B(7, 3, 25);

        Console.WriteLine("Значение свойства C для объекта класса A: " + objA.C);
        Console.WriteLine("Значение свойства C для объекта класса B (конструктор по умолчанию): " + objBDefault.C);
        Console.WriteLine("Значение свойства C для объекта класса B (собственный конструктор): " + objBCustom.C);
        Console.WriteLine("Значение свойства C2 для объекта класса B (конструктор по умолчанию): " + objBDefault.C2);
        Console.WriteLine("Значение свойства C2 для объекта класса B (собственный конструктор): " + objBCustom.C2);
    }
}
