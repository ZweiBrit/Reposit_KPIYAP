using System;

public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Triangle : Shape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double Area()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override double Perimeter()
    {
        return A + B + C;
    }

    public string Type()
    {
        if (A == B && B == C)
            return "Equilateral";
        else if (A == B || B == C || A == C)
            return "Isosceles";
        else
            return "Scalene";
    }
}

public class Rectangle : Shape
{
    public double A { get; set; }
    public double B { get; set; }

    public Rectangle(double a, double b)
    {
        A = a;
        B = b;
    }

    public override double Area()
    {
        return A * B;
    }

    public override double Perimeter()
    {
        return 2 * (A + B);
    }
}
