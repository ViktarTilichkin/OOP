using AppTransaction.SharedModels;
using AppTransaction.Service;


public class Transaction
{
    public int IdTransaction { get; }
    public string Comment { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
    public int UserId { get; set; }
    public int IdToSend { get; set; }

    public Transaction(int idTransaction, int userId)
    {
        IdTransaction = idTransaction;
        UserId = userId;
    }
    public Transaction(int idTransaction, int userId, int idToSend, string comment, decimal value, DateTime date) : this(idTransaction, userId)
    {
        Comment = comment;
        Value = value;
        Date = date;
        IdToSend = idToSend;
    }
    public override string ToString()
    {
        return $"{IdTransaction} Id поулчателя {IdToSend} {Value:N2}Br {Comment}";
    }
}