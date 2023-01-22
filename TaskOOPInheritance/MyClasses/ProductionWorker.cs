namespace MyClasses.ProductionWorker;

public class ProductionWorker : MyClasses.Employee.Employee
{
    public int Shift = 1;
    public int WorkingShift
    {
        set
        {
            if (value < 1 || value > 2)
            {

                Console.WriteLine("error");
            }
            else
            {
                Shift = value;
            }
        }
        get { return Shift; }

    }
    public int HourlyWage { get; set; }

    public ProductionWorker(int workShift, int hourWage, string name, int id) : base(name, id)
    {
        WorkingShift = workShift;
        HourlyWage = hourWage;
    }
    public override string ToString()
    {
        return $"{WorkingShift} {HourlyWage}";
    }
}