using System;

interface Ix
{
    void IxF0(double parameter);
    void IxF1();
}

interface Iy
{
    void F0(double parameter);
    void F1();
}

interface Iz
{
    void F0(double parameter);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    private double w;

    void Iz.F0(double parameter)
    {
        Console.WriteLine($"Iz.F0: {Math.Sqrt(parameter)}");
    }

    void Iz.F1()
    {
        Console.WriteLine("Iz.F1");
    }

    public void IxF0(double parameter)
    {
        Console.WriteLine($"Ix.IxF0: {Math.Sqrt(parameter)}");
    }

    public void IxF1()
    {
        Console.WriteLine("Ix.IxF1");
    }

    public void F0(double parameter)
    {
        Console.WriteLine($"Iy.F0: {parameter * parameter + 5}");
    }

    public void F1()
    {
        Console.WriteLine("Iy.F1");
    }
}

class Program
{
    static void Main()
    {
        TestClass obj = new TestClass();

        obj.F0(4); 
        ((Iz)obj).F0(4); 

        ((Ix)obj).IxF0(16);
        ((Ix)obj).IxF1();

        Iy iyObj = obj;
        iyObj.F1();
    }
}
