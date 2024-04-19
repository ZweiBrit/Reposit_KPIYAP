using System;

public class TwoDimensionalArray
{
    private int[,] array;

    public TwoDimensionalArray(int rows, int cols)
    {
        array = new int[rows, cols];
    }

    public int this[int i, int j]
    {
        get { return array[i, j]; }
        set { array[i, j] = value; }
    }

    public static bool operator >(TwoDimensionalArray a, TwoDimensionalArray b)
    {
        return SumMainDiagonal(a) > SumMainDiagonal(b);
    }

    public static bool operator <(TwoDimensionalArray a, TwoDimensionalArray b)
    {
        return SumMainDiagonal(a) < SumMainDiagonal(b);
    }

    private static int SumMainDiagonal(TwoDimensionalArray arr)
    {
        int sum = 0;
        for (int i = 0; i < Math.Min(arr.array.GetLength(0), arr.array.GetLength(1)); i++)
        {
            sum += arr[i, i];
        }
        return sum;
    }

 
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
