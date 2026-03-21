var director = new SqlReportDirector();
var builder1 = new SqlQueryBuilder();
var builder2 = new SqlQueryBuilder();
director.BuildActiveUsersReport(builder1);
director.BuildActiveUsersReport(builder2);
Console.Write(builder1.Build().CommandText);
Console.Write(builder2.Build().CommandText);
