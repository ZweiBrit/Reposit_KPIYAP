using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> dirtyPeople = new List<int> { 4, 5, 6, 7, 8 };
        List<int> scratchedPeople = new List<int> { 3, 9, 12 };

        Console.Write("Введите номер пассажира: ");
        int passengerNumber = Convert.ToInt32(Console.ReadLine());

        if (dirtyPeople.Contains(passengerNumber))
        {
            Console.WriteLine("Пассажир номер " + passengerNumber + " грязный.");
        }
        else if (scratchedPeople.Contains(passengerNumber))
        {
            Console.WriteLine("Пассажир номер " + passengerNumber + " исцарапан.");
        }
        else
        {
            Console.WriteLine("Пассажир номер " + passengerNumber + " в безопасности.");
        }
    }
}
