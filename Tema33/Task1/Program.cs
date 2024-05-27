using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task1.Contexts;
using Task1.Models;

namespace Task1
{
    class MainProgram
    {
        static async Task Main(string[] args)
        {
            string databasePath = @"..\..\..\Database\DBTur_firm.db";
            TouristContext dbContextInstance = new TouristContext(databasePath);

            Tourist touristInstance = GenerateTourist();

            int resultOfAddition = await dbContextInstance.AddTouristAsync(touristInstance);
            if (resultOfAddition > 0)
            {
                Console.WriteLine($"Турист добавлен.");
            }
            else
            {
                Console.WriteLine($"Турист не добавлен.");
            }

            List<Tourist> listOfTourists = await dbContextInstance.GetTouristsAsync();
            Console.WriteLine("Список туристов:");
            DisplayTourists(listOfTourists);

            if (listOfTourists.Count > 0)
            {
                Console.WriteLine("Выберите туриста для удаления:");
                int idOfTouristToDelete = int.Parse(Console.ReadLine());
                int resultOfDeletion = await dbContextInstance.DeleteTouristAsync(idOfTouristToDelete);
                if (resultOfDeletion > 0)
                {
                    Console.WriteLine($"Турист удален.");
                }
                else
                {
                    Console.WriteLine($"Турист не найден.");
                }
            }

            listOfTourists = await dbContextInstance.GetTouristsAsync();
            Console.WriteLine("Список туристов:");
            DisplayTourists(listOfTourists);
        }

        static Tourist GenerateTourist()
        {
            Console.WriteLine("Введите фамилию туриста:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите имя туриста:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите отчество туриста:");
            string middleName = Console.ReadLine();

            Tourist touristInstance = new Tourist
            {
                LastName = surname,
                FirstName = name,
                Patronymic = middleName
            };

            return touristInstance;
        }

        static void DisplayTourists(List<Tourist> tourists)
        {
            foreach (var tourist in tourists)
            {
                Console.WriteLine($"ID: {tourist.TouristId}, ФИО: {tourist.LastName} {tourist.FirstName} {tourist.Patronymic}");
            }
        }
    }
}
