public class SqlReportDirector
{
    public void BuildActiveUsersReport(QueryBuilder queryBuilder)
    {
        queryBuilder.SetTable("Usuarios");
        queryBuilder.AddColumn("Nombre");
        queryBuilder.AddColumn("Email");
        queryBuilder.AddWhere("Estado = 'Activo'");
    }

    public void BuildHighValueSalesReport(QueryBuilder queryBuilder)
    {
        queryBuilder.SetTable("Ventas");
        queryBuilder.AddColumn("Id");
        queryBuilder.AddColumn("Total");
        queryBuilder.AddColumn("Fecha");
        queryBuilder.AddWhere("Total > 10000");
    }
}
