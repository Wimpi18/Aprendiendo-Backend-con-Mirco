public class BankAccount
{
    public string IdAccount { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string idAccount, decimal beginningBalance)
    {
        IdAccount = idAccount;
        Balance = beginningBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Depositados ${amount}. Saldo actual: ${Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Retirados ${amount}. Saldo actual: ${Balance}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes.");
        }
    }
}
