public interface ILoanFacade
{
    Task<bool> LoanApply(string customerId, decimal loanAmount);
}
