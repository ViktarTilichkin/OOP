namespace Figurs;

public class Figur
{
    public string Name { get; private set; }

    public Figur(string name)
    {
        Name = name;
    }
    public virtual void Square()
    {
        Console.WriteLine($"{Name} error square asds ");
    }
}