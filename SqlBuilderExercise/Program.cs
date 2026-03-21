var director = new SqlReportDirector();
Console.Write(director.BuildActiveUsersReport().CommandText);
Console.Write(director.BuildHighValueSalesReport().CommandText);
