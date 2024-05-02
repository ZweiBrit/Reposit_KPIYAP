using System;

namespace DelegateArrayExample
{
    class Program
    {
        delegate int RandomNumberDelegate();

        static void Main(string[] args)
        {
            RandomNumberDelegate[] delegatesArray = new RandomNumberDelegate[5];

            for (int i = 0; i < delegatesArray.Length; i++)
            {
                delegatesArray[i] = () =>
                {

                    Random random = new Random();
                    return random.Next(1, 101);
                };
            }

            double average = CalculateAverage(delegatesArray);

            Console.WriteLine("Среднее арифметическое случайных чисел: " + average);
        }
        static double CalculateAverage(RandomNumberDelegate[] delegates)
        {
            int sum = 0;


            foreach (var del in delegates)
            {
                sum += del();
            }

            return (double)sum / delegates.Length;
        }
    }
}
