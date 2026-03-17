using LoanBankFacade;

public class LoanFacade : ILoanFacade
{
    private CustomerIdentityService customerIdentityService;
    private CreditBureauService creditBureauService;
    private InternalAccountService internalAccountService;
    private RiskAssessmentEngine riskAssessmentEngine;

    public LoanFacade(
        CustomerIdentityService customerIdentityService,
        CreditBureauService creditBureauService,
        InternalAccountService internalAccountService,
        RiskAssessmentEngine riskAssessmentEngine
    )
    {
        this.customerIdentityService = customerIdentityService;
        this.creditBureauService = creditBureauService;
        this.internalAccountService = internalAccountService;
        this.riskAssessmentEngine = riskAssessmentEngine;
    }

    public bool LoanApply(string customerId, decimal loanAmount)
    {
        bool verifyIdentity = customerIdentityService.VerifyIdentity(customerId);
        if (!verifyIdentity)
            return false;

        bool hasNoUnpaidDebts = internalAccountService.HasNoUnpaidDebts(customerId);
        if (!hasNoUnpaidDebts)
            return false;

        return riskAssessmentEngine.EvaluateRisk(
            verifyIdentity,
            creditBureauService.GetCreditScore(customerId),
            hasNoUnpaidDebts,
            loanAmount
        );
    }
}
