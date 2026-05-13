public class SecurityReportProxy : IReportService
{
    IReportService ReportService;
    IUserProvider UserProvider;

    public SecurityReportProxy(IUserProvider user, IReportService reportService)
    {
        UserProvider = user;
        ReportService = reportService;
    }

    public string GetReportData(int reportId)
    {
        if (UserProvider.GetCurrentUser().Role != "Admin" && reportId > 100)
            throw new UnauthorizedAccessException();
        return ReportService.GetReportData(reportId);
    }
}
