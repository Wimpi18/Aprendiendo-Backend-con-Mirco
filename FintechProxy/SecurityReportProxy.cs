public class SecurityReportProxy : IReportService
{
    IReportService CachedReportProxy;
    IUserProvider UserProvider;

    public SecurityReportProxy(IUserProvider user, IReportService cachedReportProxy)
    {
        UserProvider = user;
        CachedReportProxy = cachedReportProxy;
    }

    public string GetReportData(int reportId)
    {
        if (UserProvider.GetCurrentUser().Role != "Admin" && reportId > 100)
            throw new UnauthorizedAccessException();
        return CachedReportProxy.GetReportData(reportId);
    }
}
