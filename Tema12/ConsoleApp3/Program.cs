using System;

public class StringManipulation
{
    public static void ToUpper(string input)
    {
        Console.WriteLine(input.ToUpper());
    }

    public static void ToLower(string input)
    {
        Console.WriteLine(input.ToLower());
    }

    public static void CountCharacters(string input)
    {
        Console.WriteLine("Количество символов в строке: " + input.Length);
    }

    public delegate void StringManipulationDelegate(string input);

    static void Main(string[] args)
    {
        StringManipulationDelegate delegateInstance;

        string testString = "Hello, World!";

        delegateInstance = ToUpper;
        delegateInstance(testString);

        delegateInstance = ToLower;
        delegateInstance(testString);

        delegateInstance = CountCharacters;
        delegateInstance(testString);
    }
}
