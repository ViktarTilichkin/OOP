namespace Figurs;

public class Rectangle : Figur
{
    private double WidthA;
    private double WidthB;

    public Rectangle(string name, double widthA, double widthB) : base(name)
    {
        WidthA = widthA;
        WidthB = widthB;
    }

    public override void Square()
    {
        double square = WidthA * WidthB;
        Console.WriteLine($"{this} square  = {square}");
    }
    public override string ToString()
    {
        return $"Rectangle {Name}";
    }
}