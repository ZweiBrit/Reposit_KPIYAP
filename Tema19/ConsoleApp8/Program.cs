using System;

/// <summary>
/// Класс для манипуляции строками.
/// </summary>
public class StringManipulation
{
    /// <summary>
    /// Преобразует все символы в верхний регистр.
    /// </summary>
    /// <param name="input">Входная строка.</param>
    public static void ToUpper(string input)
    {
        Console.WriteLine(input.ToUpper());
    }

    /// <summary>
    /// Преобразует все символы в нижний регистр.
    /// </summary>
    /// <param name="input">Входная строка.</param>
    public static void ToLower(string input)
    {
        Console.WriteLine(input.ToLower());
    }

    /// <summary>
    /// Выводит количество символов в строке.
    /// </summary>
    /// <param name="input">Входная строка.</param>
    public static void CountCharacters(string input)
    {
        Console.WriteLine("Количество символов в строке: " + input.Length);
    }

    /// <summary>
    /// Делегат для работы с методами манипуляции строками.
    /// </summary>
    /// <param name="input">Входная строка.</param>
    public delegate void StringManipulationDelegate(string input);

    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    static void Main(string[] args)
    {
        // Создание экземпляра делегата
        StringManipulationDelegate delegateInstance;

        // Тестовая строка
        string testString = "Hello, World!";

        // Примеры использования методов манипуляции строками через делегаты
        delegateInstance = ToUpper;
        delegateInstance(testString);

        delegateInstance = ToLower;
        delegateInstance(testString);

        delegateInstance = CountCharacters;
        delegateInstance(testString);
    }
}
