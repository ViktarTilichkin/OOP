namespace MyClasses.ShiftSupervisor;

public class ShiftSupervisor : MyClasses.Employee.Employee
{
    public int YearWage { get; set; }
    public int ProductionBonus { get; set; }

    public ShiftSupervisor(string name, int id, int yearWage, int productBonus) : base (name, id)
    {
        YearWage = yearWage;
        ProductionBonus = productBonus;
    }
}