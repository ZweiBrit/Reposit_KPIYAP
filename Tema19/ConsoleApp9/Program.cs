using System;

namespace DelegateArrayExample
{
    /// <summary>
    /// Пример использования делегатов и массивов делегатов для генерации случайных чисел и вычисления их среднего значения.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Делегат для генерации случайных чисел.
        /// </summary>
        /// <returns>Случайное целое число.</returns>
        delegate int RandomNumberDelegate();

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            // Массив делегатов для генерации случайных чисел
            RandomNumberDelegate[] delegatesArray = new RandomNumberDelegate[5];

            // Инициализация массива делегатов
            for (int i = 0; i < delegatesArray.Length; i++)
            {
                delegatesArray[i] = () =>
                {
                    Random random = new Random();
                    return random.Next(1, 101);
                };
            }

            // Вычисление среднего арифметического случайных чисел
            double average = CalculateAverage(delegatesArray);

            // Вывод результата
            Console.WriteLine("Среднее арифметическое случайных чисел: " + average);
        }

        /// <summary>
        /// Вычисляет среднее арифметическое для массива делегатов, каждый из которых генерирует случайное число.
        /// </summary>
        /// <param name="delegates">Массив делегатов для генерации случайных чисел.</param>
        /// <returns>Среднее арифметическое случайных чисел.</returns>
        static double CalculateAverage(RandomNumberDelegate[] delegates)
        {
            int sum = 0;

            // Вызов каждого делегата и суммирование полученных чисел
            foreach (var del in delegates)
            {
                sum += del();
            }

            // Вычисление среднего арифметического
            return (double)sum / delegates.Length;
        }
    }
}
