using System;

public class MyInfo
{
    public delegate void NameChangedDelegate(string oldName, string newName);

    public event NameChangedDelegate NameChanged;

    private string _name;

    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                string oldName = _name;
                _name = value;
                NameChanged?.Invoke(oldName, _name);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyInfo myInfo = new MyInfo();

        myInfo.NameChanged += (oldName, newName) =>
        {
            Console.WriteLine($"Имя изменено с {oldName} на {newName}");
        };

        myInfo.Name = "Ваше имя";
    }
}
