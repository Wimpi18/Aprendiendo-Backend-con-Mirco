using LoanBankFacade;

public class LoanFacade : ILoanFacade
{
    private RiskAssessmentEngine riskAssessmentEngine;
    private ICustomerBackgroundFacade customerBackgroundFacade;

    public LoanFacade(
        RiskAssessmentEngine riskAssessmentEngine,
        ICustomerBackgroundFacade customerBackgroundFacade
    )
    {
        this.riskAssessmentEngine = riskAssessmentEngine;
        this.customerBackgroundFacade = customerBackgroundFacade;
    }

    public async Task<bool> LoanApply(string customerId, decimal loanAmount)
    {
        (bool passedFilters, int creditScore) = await customerBackgroundFacade.CheckBackgroundAsync(
            customerId
        );
        return riskAssessmentEngine.EvaluateRisk(
            passedFilters,
            creditScore,
            passedFilters,
            loanAmount
        );
    }
}
