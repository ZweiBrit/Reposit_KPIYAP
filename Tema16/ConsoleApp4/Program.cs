using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFileName = "input.txt";
        string outputFileName = "output.txt";

        ReverseSymbols(inputFileName, outputFileName);
        Console.WriteLine($"Строки файла '{inputFileName}' переписаны с заменой символов и записаны в файл '{outputFileName}'.");
    }

    static void ReverseSymbols(string inputFileName, string outputFileName)
    {
        using (StreamReader reader = new StreamReader(inputFileName))
        using (StreamWriter writer = new StreamWriter(outputFileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string reversedLine = ReverseCharacters(line);
                writer.WriteLine(reversedLine);
            }
        }
    }

    static string ReverseCharacters(string line)
    {
        char[] characters = line.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i] == '0')
                characters[i] = '1';
            else if (characters[i] == '1')
                characters[i] = '0';
        }
        return new string(characters);
    }
}
