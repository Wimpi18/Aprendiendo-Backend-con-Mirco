User user = new User();

user.Name = "Winsor";
user.Role = "Admin";

// user.Name = "Emily";
// user.Role = "Diseñadora";

SecurityReportProxy securityReportProxy = new(
    user,
    new CachedReportProxy(new VirtualReportProxy())
);

Console.WriteLine(securityReportProxy.GetReportData(1000));
