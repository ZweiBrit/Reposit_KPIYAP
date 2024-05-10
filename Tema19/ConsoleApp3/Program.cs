using System;

/// <summary>
/// Представляет двумерный массив целых чисел.
/// </summary>
public class TwoDimensionalArray
{
    private int[,] array;

    /// <summary>
    /// Создает новый двумерный массив заданных размеров.
    /// </summary>
    /// <param name="rows">Количество строк в массиве.</param>
    /// <param name="cols">Количество столбцов в массиве.</param>
    public TwoDimensionalArray(int rows, int cols)
    {
        array = new int[rows, cols];
    }

    /// <summary>
    /// Получает или задает значение элемента массива по указанным индексам.
    /// </summary>
    /// <param name="i">Индекс строки.</param>
    /// <param name="j">Индекс столбца.</param>
    /// <returns>Значение элемента массива.</returns>
    public int this[int i, int j]
    {
        get { return array[i, j]; }
        set { array[i, j] = value; }
    }

    /// <summary>
    /// Оператор "больше", сравнивающий суммы элементов главной диагонали двух массивов.
    /// </summary>
    public static bool operator >(TwoDimensionalArray a, TwoDimensionalArray b)
    {
        return SumMainDiagonal(a) > SumMainDiagonal(b);
    }

    /// <summary>
    /// Оператор "меньше", сравнивающий суммы элементов главной диагонали двух массивов.
    /// </summary>
    public static bool operator <(TwoDimensionalArray a, TwoDimensionalArray b)
    {
        return SumMainDiagonal(a) < SumMainDiagonal(b);
    }

    /// <summary>
    /// Вычисляет сумму элементов главной диагонали массива.
    /// </summary>
    private static int SumMainDiagonal(TwoDimensionalArray arr)
    {
        int sum = 0;
        for (int i = 0; i < Math.Min(arr.array.GetLength(0), arr.array.GetLength(1)); i++)
        {
            sum += arr[i, i];
        }
        return sum;
    }

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main(string[] args)
    {
        TwoDimensionalArray arr1 = new TwoDimensionalArray(3, 3);
        TwoDimensionalArray arr2 = new TwoDimensionalArray(3, 3);

        arr1[0, 0] = 1; arr1[1, 1] = 2; arr1[2, 2] = 3;
        arr2[0, 0] = 4; arr2[1, 1] = 5; arr2[2, 2] = 6;

        if (arr1 > arr2)
        {
            Console.WriteLine("Сумма элементов главной диагонали arr1 больше, чем у arr2");
        }
        else if (arr1 < arr2)
        {
            Console.WriteLine("Сумма элементов главной диагонали arr1 меньше, чем у arr2");
        }
        else
        {
            Console.WriteLine("Суммы элементов главных диагоналей arr1 и arr2 равны");
        }
    }
}
