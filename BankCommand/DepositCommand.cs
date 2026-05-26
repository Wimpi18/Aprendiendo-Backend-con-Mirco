public class DepositCommand : ICommand
{
    private BankAccount BankAccount;
    private decimal Amount;

    public DepositCommand(BankAccount bankAccount, decimal amount)
    {
        BankAccount = bankAccount;
        Amount = amount;
    }

    public void Execute()
    {
        BankAccount.Deposit(Amount);
    }

    public void Undo()
    {
        BankAccount.Withdraw(Amount);
    }
}
