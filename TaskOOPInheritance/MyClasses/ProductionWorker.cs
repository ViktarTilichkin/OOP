namespace MyClasses.ProductionWorker;

public class ProductionWorker : MyClasses.Employee.Employee
{
    private int shift = 1;
    public int WorkingShift
    {
        get => shift;
        set
        {
            if (value < 1 || value > 2)
            {
                throw new Exception("Wprking Shift out range");
            }
            else
            {
                shift = value;
            }
        }

    }
    public double HourlyWage { get; set; }

    public ProductionWorker(int workShift, double hourWage, string name, int id) : base(name, id)
    {
        WorkingShift = workShift;
        HourlyWage = hourWage;
    }
    public override void SetId(int id)
    {
        if (id > 0)
        {
            Id = id;
            Console.WriteLine("succesful");
        }
        else
        {
            Console.WriteLine("error input");
        }
    }
    public override void SetName(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            Name = name;
            Console.WriteLine("succesful");
        }
        else
        {
            Console.WriteLine("error input");
        }
    }

    public void SetWorkingShift(int shift)
    {
        WorkingShift = shift;
    }
    public void SetHourlyWage(double hourWage)
    {
        HourlyWage = hourWage;
    }

    public override string ToString()
    {
        return $" Id : {Id} Name: {Name} WorkShift:{WorkingShift} Hourly Wage : {HourlyWage}";
    }
}