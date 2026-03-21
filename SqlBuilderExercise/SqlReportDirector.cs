public class SqlReportDirector
{
    public SqlQuery BuildActiveUsersReport()
    {
        SqlQueryBuilder builder = new SqlQueryBuilder();
        builder.SetTable("Usuarios");
        builder.AddColumn("Nombre");
        builder.AddColumn("Email");
        builder.AddWhere("Estado = 'Activo'");
        return builder.Build();
    }

    public SqlQuery BuildHighValueSalesReport()
    {
        SqlQueryBuilder builder = new SqlQueryBuilder();
        builder.SetTable("Ventas");
        builder.AddColumn("Id");
        builder.AddColumn("Total");
        builder.AddColumn("Fecha");
        builder.AddWhere("Total > 10000");
        return builder.Build();
    }
}
