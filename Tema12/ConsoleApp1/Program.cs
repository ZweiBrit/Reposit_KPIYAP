using System;

delegate double CalcFigure(double R);

class Program
{

    static double Get_Length(double R)
    {
        return 2 * Math.PI * R;
    }

    static double Get_Area(double R)
    {
        return Math.PI * R * R;
    }

    static double Get_Volume(double R)
    {
        return (4.0 / 3.0) * Math.PI * R * R * R;
    }

    static void Main(string[] args)
    {
        CalcFigure CF;

        CF = Get_Length;
        double circumference = CF(5); 
        Console.WriteLine("Длина окружности: " + circumference);

        CF = Get_Area;
        double area = CF(5);
        Console.WriteLine("Площадь круга: " + area);

        CF = Get_Volume;
        double volume = CF(5);
        Console.WriteLine("Объем шара: " + volume);
    }
}
