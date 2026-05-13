public class VirtualReportProxy : IReportService
{
    private IReportService _realService;
    private readonly object _lock = new object();

    public string GetReportData(int reportId)
    {
        if (_realService == null)
            lock (_lock)
                if (_realService == null)
                    _realService = new LegacyReportService();

        return _realService.GetReportData(reportId);
    }
}
