using System.Collections.Concurrent;

public class CachedReportProxy : IReportService
{
    ConcurrentDictionary<int, string> LegacyReportsCache = [];
    IReportService LegacyReportService;

    public CachedReportProxy(IReportService legacyReportService)
    {
        LegacyReportService = legacyReportService;
    }

    public string GetReportData(int reportId)
    {
        return LegacyReportsCache.GetOrAdd(reportId, LegacyReportService.GetReportData(reportId));
    }
}
