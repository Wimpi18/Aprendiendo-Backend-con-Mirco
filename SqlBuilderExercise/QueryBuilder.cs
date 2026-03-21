public interface QueryBuilder
{
    public void SetTable(string tableName);
    public void AddColumn(string columnName);
    public void AddWhere(string condition);
    public SqlQuery Build();
}
