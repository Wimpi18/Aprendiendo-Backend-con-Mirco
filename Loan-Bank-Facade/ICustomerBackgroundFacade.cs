public interface ICustomerBackgroundFacade
{
    Task<(bool passedFilters, int creditScore)> CheckBackgroundAsync(string customerId);
}
