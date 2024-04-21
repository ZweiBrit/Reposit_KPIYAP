using System;

class Program
{
    static void Main()
    {
          int[,] residents = new int[12, 4]; 

  
        Random random = new Random();
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                residents[i, j] = random.Next(1, 6);
            }
        }

        int sum3rdFloor = residents[2, 0] + residents[2, 1] + residents[2, 2] + residents[2, 3];
        int sum4thFloor = residents[3, 0] + residents[3, 1] + residents[3, 2] + residents[3, 3];

        if (sum3rdFloor > sum4thFloor)
        {
            Console.WriteLine($"На 3-м этаже больше жильцов ({sum3rdFloor} человек).");
        }
        else if (sum4thFloor > sum3rdFloor)
        {
            Console.WriteLine($"На 4-м этаже больше жильцов ({sum4thFloor} человек).");
        }
        else
        {
            Console.WriteLine("На 3-м и 4-м этажах одинаковое количество жильцов.");
        }

        Console.ReadLine();
    }
}
