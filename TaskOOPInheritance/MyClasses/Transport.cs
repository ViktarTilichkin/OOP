namespace MyClasses.Transport;

public class Transport
{
    public double Spead;
    public string? Name;

    public Transport(string name)
    {
        Name = name;
    }
    public Transport(double spead, string name) : this(name)
    {
        Spead = spead;
    }

    public void Moving()
    {
        Console.WriteLine($"{Name} is moving ");
    }
    public void Stopping()
    {
        Console.WriteLine($"{Name} is stopping");
    }
}