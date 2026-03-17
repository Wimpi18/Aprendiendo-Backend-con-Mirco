namespace LoanBankFacade;

public class CreditBureauService
{
    public async Task<int> GetCreditScoreAsync(string customerId)
    {
        Console.WriteLine(
            $"[CreditBureau] Consultando puntaje crediticio externo para {customerId}..."
        );
        return 750;
    }
}
