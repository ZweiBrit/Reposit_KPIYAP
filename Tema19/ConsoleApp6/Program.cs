using System;

/// <summary>
/// Делегат для расчета характеристик фигуры.
/// </summary>
/// <param name="R">Радиус фигуры.</param>
/// <returns>Значение характеристики фигуры.</returns>
delegate double CalcFigure(double R);

class Program
{
    /// <summary>
    /// Возвращает длину окружности для заданного радиуса.
    /// </summary>
    /// <param name="R">Радиус окружности.</param>
    /// <returns>Длина окружности.</returns>
    static double Get_Length(double R)
    {
        return 2 * Math.PI * R;
    }

    /// <summary>
    /// Возвращает площадь круга для заданного радиуса.
    /// </summary>
    /// <param name="R">Радиус круга.</param>
    /// <returns>Площадь круга.</returns>
    static double Get_Area(double R)
    {
        return Math.PI * R * R;
    }

    /// <summary>
    /// Возвращает объем шара для заданного радиуса.
    /// </summary>
    /// <param name="R">Радиус шара.</param>
    /// <returns>Объем шара.</returns>
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
