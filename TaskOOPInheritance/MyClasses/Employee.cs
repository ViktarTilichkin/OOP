namespace MyClasses.Employee;

public class Employee
{
    public string Name { get; set; }
    public int Id { get; }
    
    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
}