using System;

namespace SortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double A1 = 5, B1 = 2, C1 = 8;
                double A2 = 3, B2 = 7, C2 = 1;

                Console.WriteLine("Original values for Set 1: A1 = {0}, B1 = {1}, C1 = {2}", A1, B1, C1);
                Console.WriteLine("Original values for Set 2: A2 = {0}, B2 = {1}, C2 = {2}", A2, B2, C2);

                SortDec3(ref A1, ref B1, ref C1);
                SortDec3(ref A2, ref B2, ref C2);

                Console.WriteLine("Sorted values for Set 1: A1 = {0}, B1 = {1}, C1 = {2}", A1, B1, C1);
                Console.WriteLine("Sorted values for Set 2: A2 = {0}, B2 = {1}, C2 = {2}", A2, B2, C2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат числа!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void SortDec3(ref double A, ref double B, ref double C)
        {
            if (A < B)
                Swap(ref A, ref B);
            if (B < C)
                Swap(ref B, ref C);
            if (A < B)
                Swap(ref A, ref B);
        }

        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
