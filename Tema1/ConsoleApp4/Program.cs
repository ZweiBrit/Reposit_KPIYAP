using System;

class Program
{
    static void Main()
    {
        int A = 3; 
        int B = 30; 
        int i;

        Console.WriteLine("Числа, кратные трем, используя цикл for:");
        for (i = A; i <= B; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        i = A;
        Console.WriteLine("Числа, кратные трем, используя цикл while:");
        while (i <= B)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

     
        i = A;
        Console.WriteLine("Числа, кратные трем, используя цикл do-while:");
        do
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= B);
    }
}
