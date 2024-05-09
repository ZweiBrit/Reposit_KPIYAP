using System;

class Program
{
    static void Main()
    {
        // Создаем новый объект класса Phone
        Phone myPhone = new Phone("iPhone 13", "Apple", 999.99);

        // Выводим информацию о телефоне
        Console.WriteLine(myPhone.ToString());

        // Изменяем модель телефона
        myPhone.ChangeModel("iPhone 13 Pro");
        Console.WriteLine($"Новая модель: {myPhone.Model}");

        // Изменяем производителя телефона
        myPhone.ChangeManufacturer("Apple Inc.");
        Console.WriteLine($"Новый производитель: {myPhone.Manufacturer}");

        // Изменяем цену телефона
        myPhone.ChangePrice(1099.99);
        Console.WriteLine($"Новая цена: {myPhone.Price}");
    }
}
