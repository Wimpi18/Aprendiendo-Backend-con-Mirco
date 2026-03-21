public class SqlReportDirector
{
    public SqlQuery BuildActiveUsersReport(QueryBuilder queryBuilder)
    {
        return queryBuilder
            .SetTable("Usuarios")
            .AddColumn("Nombre")
            .AddColumn("Email")
            .AddWhere("Estado = 'Activo'")
            .Build();
    }

    public SqlQuery BuildHighValueSalesReport(QueryBuilder queryBuilder)
    {
        return queryBuilder
            .SetTable("Ventas")
            .AddColumn("Id")
            .AddColumn("Total")
            .AddColumn("Fecha")
            .AddWhere("Total > 10000")
            .Build();
    }
}
