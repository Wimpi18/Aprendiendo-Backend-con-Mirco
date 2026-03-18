using LoanBankFacade;

public class CustomerBackgroundFacade : ICustomerBackgroundFacade
{
    private CustomerIdentityService customerIdentityService;
    private CreditBureauService creditBureauService;
    private InternalAccountService internalAccountService;

    public CustomerBackgroundFacade(
        CustomerIdentityService customerIdentityService,
        CreditBureauService creditBureauService,
        InternalAccountService internalAccountService
    )
    {
        this.customerIdentityService = customerIdentityService;
        this.creditBureauService = creditBureauService;
        this.internalAccountService = internalAccountService;
    }

    public async Task<(bool passedFilters, int creditScore)> CheckBackgroundAsync(string customerId)
    {
        bool verifyIdentity = customerIdentityService.VerifyIdentity(customerId);
        if (!verifyIdentity)
            return (false, 0);

        bool hasNoUnpaidDebts = internalAccountService.HasNoUnpaidDebts(customerId);
        if (!hasNoUnpaidDebts)
            return (false, 0);

        return (true, await creditBureauService.GetCreditScoreAsync(customerId));
    }
}
