namespace ClassData;

public class User
{
    public string Name { get; set; } = "Default Name";
    public int Id { get;}
    public int Age { get; set; } = 0;
    public User()
    {

    }
    public User(int id)
    {
        Id = id;
    }
    public override string ToString()
    {
        return $"Hello! Id {Id} Name {Name} Age {Age}";
    }
}