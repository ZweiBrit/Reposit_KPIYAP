public class Государство
{
    public string Название { get; set; }
}

public class Монархия : Государство
{
    public string Монарх { get; set; }
}

public class Королевство : Монархия
{
    public string Король { get { return Монарх; } set { Монарх = value; } }
}

public class Республика : Государство
{
    public string Президент { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Королевство королевство = new Королевство { Название = "Великобритания", Король = "Елизавета II" };
        Республика республика = new Республика { Название = "Франция", Президент = "Эммануэль Макрон" };

        Console.WriteLine($"Королевство: {королевство.Название}, Король: {королевство.Король}");
        Console.WriteLine($"Республика: {республика.Название}, Президент: {республика.Президент}");
    }
}
