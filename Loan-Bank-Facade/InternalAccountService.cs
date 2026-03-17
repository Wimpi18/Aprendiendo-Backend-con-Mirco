namespace LoanBankFacade;

public class InternalAccountService
{
    public bool HasNoUnpaidDebts(string customerId)
    {
        Console.WriteLine(
            $"[InternalAccount] Revisando historial de cuentas internas de {customerId}..."
        );
        return true;
    }
}
