var director = new SqlReportDirector();
var builder = new SqlQueryBuilder();
Console.Write(director.BuildActiveUsersReport(builder).CommandText + "\n\n");
Console.Write(director.BuildHighValueSalesReport(builder).CommandText);
