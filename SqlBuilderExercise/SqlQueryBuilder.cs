public class SqlQueryBuilder : QueryBuilder
{
    string _table = "",
        _columns = "",
        _where = "";

    public void SetTable(string tableName)
    {
        if (string.IsNullOrEmpty(_table))
            _table = tableName;
        else
            _table += $", {tableName}";
    }

    public void AddColumn(string columnName)
    {
        if (string.IsNullOrEmpty(_columns))
            _columns = columnName;
        else
            _columns += $", {columnName}";
    }

    public void AddWhere(string condition)
    {
        if (string.IsNullOrEmpty(_where))
            _where = condition;
        else
            _where += $" AND {condition}";
    }

    public SqlQuery Build()
    {
        string result = "";
        result += string.IsNullOrEmpty(_columns) ? "SELECT *" : "SELECT " + _columns + "\n";
        result += "FROM " + _table + "\n";
        result += string.IsNullOrEmpty(_where) ? "" : "WHERE " + _where;
        return new SqlQuery(result);
    }
}
