public interface QueryBuilder
{
    public QueryBuilder SetTable(string tableName);
    public QueryBuilder AddColumn(string columnName);
    public QueryBuilder AddWhere(string condition);
    public void Reset();
    public SqlQuery Build();
}
