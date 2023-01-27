namespace ClassData;


public class TestData
{
    public string Name;
    private int Age;

    protected int AgeS;

    public TestData()
    {

    }
    public TestData(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static void Hello(int i, int j)
    {
        Console.WriteLine(i + j);
    }
    public virtual void Print(string hello)
    {
        Console.WriteLine($"hello {hello} {Name} {Age}");
    }
    private void Print2(string hello)
    {
        Console.WriteLine($"hello {hello} {Name} {Age}");
    }
}