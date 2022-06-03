namespace Accounts;

public class SavingsAccount: BankAccount
{
    public decimal InterestRate { get; set; }
    public void AddMonthlyInterest()
    {
        Balance += Balance * InterestRate;
    }
}