using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');

        // Поменять местами первое и последнее слова в предложении.
        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;
        Console.WriteLine("После замены первого и последнего слов: " + string.Join(" ", words));

        // Склеить второе и третье слова в предложении.
        if (words.Length >= 3)
        {
            words[1] = words[1] + words[2];
            words = words.Where((word, index) => index != 2).ToArray();
            Console.WriteLine("После склеивания второго и третьего слов: " + string.Join(" ", words));
        }

        // Третье слово предложения вывести в обратном порядке.
        if (words.Length >= 3)
        {
            char[] thirdWordReversed = words[2].ToCharArray();
            Array.Reverse(thirdWordReversed);
            words[2] = new string(thirdWordReversed);
            Console.WriteLine("Третье слово в обратном порядке: " + string.Join(" ", words));
        }

        // В первом слове предложения вырезать первые две буквы.
        if (words[0].Length > 2)
        {
            words[0] = words[0].Substring(2);
            Console.WriteLine("После удаления первых двух букв в первом слове: " + string.Join(" ", words));
        }
    }
}
