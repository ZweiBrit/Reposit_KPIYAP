public class A
{
    public int a { get; set; }
    public int b { get; set; }

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public double CalculateExpression()
    {
        return 1 / Math.Pow(a, 2) - 1 / Math.Pow(a, 3);
    }

    public int CubeSum()
    {
        return (int)Math.Pow(a + b, 3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        A obj = new A(2, 3);
        Console.WriteLine("Результат вычисления выражения: " + obj.CalculateExpression());
        Console.WriteLine("Куб суммы a и b: " + obj.CubeSum());
    }
}
