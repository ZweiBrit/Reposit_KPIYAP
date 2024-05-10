using System;
using System.Collections.Generic;

class PrototypeClass<T> where T : class, ICloneable
{
    private List<T> items;

    public PrototypeClass()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public bool RemoveItem(T item)
    {
        return items.Remove(item);
    }

    public PrototypeClass<T> Clone()
    {
        PrototypeClass<T> clone = new PrototypeClass<T>();
        foreach (T item in items)
        {
            clone.AddItem((T)item.Clone());
        }
        return clone;
    }

    public List<T> DisplayItems()
    {
        List<T> displayedItems = new List<T>();
        foreach (T item in items)
        {
            displayedItems.Add(item);
            Console.WriteLine(item.ToString());
        }
        return displayedItems;
    }
}

class Person : ICloneable
{
    public string Name { get; set; }
    public int? Age { get; set; }

    public Person(string name, int? age)
    {
        Name = name;
        Age = age;
    }

    public object Clone()
    {
        return new Person(Name, Age);
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {(Age.HasValue ? Age.ToString() : "Unknown")}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        PrototypeClass<Person> prototype = new PrototypeClass<Person>();

        prototype.AddItem(new Person("John", 30));
        prototype.AddItem(new Person("Alice", null));

        Console.WriteLine("Original items:");
        List<Person> originalItems = prototype.DisplayItems();

        PrototypeClass<Person> clone = prototype.Clone();
        List<Person> clonedItems = clone.DisplayItems();

        clone.RemoveItem(clonedItems[0]);
        clone.AddItem(new Person("Bob", 25));

        Console.WriteLine("\nCloned items:");
        clone.DisplayItems();
    }
}
