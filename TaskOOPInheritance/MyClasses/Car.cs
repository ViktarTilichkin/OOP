namespace MyClasses.Car;

public class Car : MyClasses.Transport.Transport
{
    public int Type { get; set; }
    public Car(double spead, string name, int type) : base(spead, name)
    {
        Type = type;
    }
    public Car(string name, int type) : base(name)
    {
        Type = type;
    }
    public void Drift()
    {
        Console.WriteLine($"{Name} is drift");
    }
}