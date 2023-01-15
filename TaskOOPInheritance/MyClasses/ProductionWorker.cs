namespace MyClasses.ProductionWorker;

public class ProductionWorker : MyClasses.Employee.Employee
{
    public int WorkingShift { get; set; }
    public int HourlyWage { get; set; }

    public ProductionWorker(int workShift, int hourWage, string name, int id) : base(name , id)
    {
        WorkingShift = workShift;
        HourlyWage = hourWage;
    }
}  