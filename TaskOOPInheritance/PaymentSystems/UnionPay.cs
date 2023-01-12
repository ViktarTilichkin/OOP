namespace PaymentSystems;

public class UnionPay : AccountPayment
{
    public UnionPay(string number) : base(number)
    {
    }

    public UnionPay(string number, decimal money) : base(number, money)
    {
    }
    public override bool Payment(string information, decimal request)
    {
        request *= (decimal)1.03;
        if (Money >= request)
        {
            History.Add($"{information} -{request}");
            Money -= request;
            return true;
        }
        return false;
    }

    public override decimal SetMoney(decimal money)
    {
        // switch (money)
        // {
        //     case < 50:
        //         coef = 0.001;
        //         break;
        //     case > 50 when money < 100:
        //         coef = 0.005;
        //         break;
        //     case > 100 when money < 500:
        //         coef = 0.1;
        //         break;
        //     case > 500 when money < 1000:
        //         coef = 0.2;
        //         break;
        //     case > 1000:
        //         coef = 0.3;
        //         break;
        //     default;
        // }
        decimal com = 0;

        if (money < 50)
        {
            com = money * (decimal)0.0001;
        }
        else if (money < 100)
        {
            com = money * (decimal)0.0005;
        }
        else if (money < 500)
        {
            com = money * (decimal)0.001;

        }
        else if (money < 1000)
        {
            com = money * (decimal)0.002;

        }
        else
        {
            com = money * (decimal)0.003;
        }
        Money += money - com;
        History.Add($" На ваш счет +{money - com}");
        return com;
    }
    //     до 50 = 0.01%
    // до 100 = 0.05%
    // до 500 = 0.1%
    // до 1000 = 0.2%
    // более 0.3%
}