using System;

class FixedLengthStringArray
{
    private string[] array;
    private int lowerBound;
    private int upperBound;

    public FixedLengthStringArray(int lowerBound, int upperBound)
    {
        if (lowerBound > upperBound)
        {
            throw new ArgumentException("Lower bound cannot be greater than upper bound.");
        }

        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        array = new string[upperBound - lowerBound + 1];
    }

    public string this[int index]
    {
        get
        {
            if (index < lowerBound || index > upperBound)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return array[index - lowerBound];
        }
        set
        {
            if (index < lowerBound || index > upperBound)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            array[index - lowerBound] = value;
        }
    }

    public FixedLengthStringArray Concatenate(FixedLengthStringArray other)
    {
        if (this.Length != other.Length)
        {
            throw new InvalidOperationException("Arrays must have the same length for concatenation.");
        }

        FixedLengthStringArray resultArray = new FixedLengthStringArray(lowerBound, upperBound);

        for (int i = lowerBound; i <= upperBound; i++)
        {
            resultArray[i] = this[i] + other[i];
        }

        return resultArray;
    }

    public void PrintElement(int index)
    {
        Console.WriteLine($"Element at index {index}: {this[index]}");
    }

    public void PrintArray()
    {
        Console.WriteLine("Array:");
        for (int i = lowerBound; i <= upperBound; i++)
        {
            Console.WriteLine($"[{i}]: {this[i]}");
        }
    }

    public int Length => upperBound - lowerBound + 1;
}

class Program
{
    static void Main(string[] args)
    {
        FixedLengthStringArray array1 = new FixedLengthStringArray(0, 4);
        FixedLengthStringArray array2 = new FixedLengthStringArray(0, 4);

        array1[0] = "Hello";
        array1[1] = " ";
        array1[2] = "world";
        array1[3] = "!";
        array1[4] = " ";

        array2[0] = "How";
        array2[1] = " ";
        array2[2] = "are";
        array2[3] = " ";
        array2[4] = "you?";

        array1.PrintArray();
        array2.PrintArray();

        FixedLengthStringArray concatenatedArray = array1.Concatenate(array2);
        concatenatedArray.PrintArray();

        array1.PrintElement(2);
        array2.PrintElement(3);
    }
}
