namespace LoanBankFacade;

public class CreditBureauService
{
    public int GetCreditScore(string customerId)
    {
        Console.WriteLine(
            $"[CreditBureau] Consultando puntaje crediticio externo para {customerId}..."
        );
        return 750;
    }
}
