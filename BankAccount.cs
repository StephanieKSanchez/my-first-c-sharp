
namespace Accounts;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public string Owner { get; set; }
    public decimal Balance { get; set; }
    public BankAccount()
    {
        AccountNumber = "My account";
        Owner = "Bob";
        Balance = decimal.MaxValue;
    }
    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
    }
    public void MakeDeposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("What are you doing?");
        }
        this.Balance += amount;
    }
}