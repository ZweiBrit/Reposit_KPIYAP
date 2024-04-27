using System;
using System.Linq;

struct NOTE
{
    public string LastName;
    public string FirstName;
    public string PhoneNumber;
    public int[] BirthDate;
}

class Program
{
    static void Main(string[] args)
    {
        NOTE[] notes = new NOTE[8];

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Введите фамилию:");
            notes[i].LastName = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            notes[i].FirstName = Console.ReadLine();

            Console.WriteLine("Введите номер телефона:");
            notes[i].PhoneNumber = Console.ReadLine();

            Console.WriteLine("Введите дату рождения (день, месяц, год):");
            notes[i].BirthDate = new int[3];
            for (int j = 0; j < 3; j++)
            {
                notes[i].BirthDate[j] = int.Parse(Console.ReadLine());
            }
        }

        notes = notes.OrderBy(n => n.PhoneNumber.Substring(0, 3)).ToArray();

        Console.WriteLine("Введите фамилию для поиска:");
        string searchLastName = Console.ReadLine();

        var note = notes.FirstOrDefault(n => n.LastName == searchLastName);

        if (note.LastName != null)
        {
            Console.WriteLine($"Фамилия: {note.LastName}\nИмя: {note.FirstName}\nНомер телефона: {note.PhoneNumber}\nДата рождения: {string.Join(".", note.BirthDate)}");
        }
        else
        {
            Console.WriteLine("Человек с такой фамилией не найден.");
        }
    }
}
