public class LegacyReportService : IReportService
{
    public string GetReportData(int reportId)
    {
        Console.WriteLine($"[Network] Fetching report {reportId} from external provider...");
        Thread.Sleep(2000); // Simula latencia de red
        return $"Critical Financial Data for Report #{reportId}";
    }
}
