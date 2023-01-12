namespace PaymentSystems;

public class Visa : AccountPayment
{
    public Visa(string number) : base(number)
    {

    }
    public Visa(string number, decimal money) : base(number, money)
    {
    }
    public override bool Payment(string information, decimal request)
    {
        if (Money > request)
        {
            History.Add($"{information} -{request}");
            Money -= request;
            return true;
        }
        return false;
    }

    public override decimal SetMoney(decimal money)
    {
        decimal comission = money * (decimal)0.001;
        money -= comission;
        Money += money;
        History.Add($" На ваш счет +{money}");
        return comission;
    }
}
