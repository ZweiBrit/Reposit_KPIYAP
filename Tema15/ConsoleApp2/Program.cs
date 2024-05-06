using System;
using System.Collections.Generic;

class MyDictionary<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>> items;

    public MyDictionary()
    {
        items = new List<KeyValuePair<TKey, TValue>>();
    }

    public void Add(TKey key, TValue value)
    {
        items.Add(new KeyValuePair<TKey, TValue>(key, value));
    }

    public TValue this[TKey key]
    {
        get
        {
            foreach (var pair in items)
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }
            throw new KeyNotFoundException();
        }
    }

    public int Count
    {
        get { return items.Count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

        myDictionary.Add("one", 1);
        myDictionary.Add("two", 2);
        myDictionary.Add("three", 3);

        Console.WriteLine("Elements in MyDictionary:");
        Console.WriteLine("Key: one, Value: " + myDictionary["one"]);
        Console.WriteLine("Key: two, Value: " + myDictionary["two"]);
        Console.WriteLine("Key: three, Value: " + myDictionary["three"]);
    }
}
