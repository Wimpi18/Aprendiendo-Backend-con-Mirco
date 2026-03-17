namespace LoanBankFacade;
public class RiskAssessmentEngine
{
    public bool EvaluateRisk(bool identityVerified, int creditScore, bool noUnpaidDebts, decimal loanAmount)
    {
        Console.WriteLine($"[RiskEngine] Procesando algoritmo de riesgo para un monto de ${loanAmount}...");
        
        if (identityVerified && noUnpaidDebts && creditScore >= 700)
        {
            Console.WriteLine("[RiskEngine] Resultado: Préstamo APROBADO.");
            return true;
        }
        
        Console.WriteLine("[RiskEngine] Resultado: Préstamo DENEGADO.");
        return false;
    }
}