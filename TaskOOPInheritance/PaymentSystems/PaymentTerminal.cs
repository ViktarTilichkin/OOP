namespace PaymentSystems;

public class PaymentTerminal
{
    private string NameTerminal;

    private decimal MoneyTerm;

    public PaymentTerminal(string name)
    {
        NameTerminal = name;
    }

    public void SetMoneyByPaymentSystem(decimal money, AccountPayment account)
    {
        if (account.Payment($"request money form {NameTerminal}", money))
        {
            MoneyTerm += money;
            Console.WriteLine("Succesful");
        }
        else
        {
            Console.WriteLine("not enough money");
        }
    }

    public override string ToString()
    {
        return $"Terminal name : {NameTerminal} , money {MoneyTerm}";
    }
}