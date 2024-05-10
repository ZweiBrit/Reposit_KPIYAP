using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = "abc#d##c";
        string result = ProcessBackspaces(input);
        Console.WriteLine(result);
    }

    static string ProcessBackspaces(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop(); 
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        char[] resultArray = stack.ToArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}
