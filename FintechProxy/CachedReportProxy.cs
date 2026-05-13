using System.Collections.Concurrent;

public class CachedReportProxy : IReportService
{
    ConcurrentDictionary<int, string> LegacyReportsCache = [];
    IReportService ReportService;

    public CachedReportProxy(IReportService reportService)
    {
        ReportService = reportService;
    }

    public string GetReportData(int reportId)
    {
        return LegacyReportsCache.GetOrAdd(reportId, ReportService.GetReportData(reportId));
    }
}
