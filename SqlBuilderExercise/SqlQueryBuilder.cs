public class SqlQueryBuilder : QueryBuilder
{
    string _table = "",
        _columns = "",
        _where = "";

    public void Reset()
    {
        _table = _columns = _where = "";
    }

    public QueryBuilder SetTable(string tableName)
    {
        if (string.IsNullOrEmpty(_table))
            _table = tableName;
        else
            _table += $", {tableName}";
        return this;
    }

    public QueryBuilder AddColumn(string columnName)
    {
        if (string.IsNullOrEmpty(_columns))
            _columns = columnName;
        else
            _columns += $", {columnName}";
        return this;
    }

    public QueryBuilder AddWhere(string condition)
    {
        if (string.IsNullOrEmpty(_where))
            _where = condition;
        else
            _where += $" AND {condition}";
        return this;
    }

    public SqlQuery Build()
    {
        string result = "";
        result += string.IsNullOrEmpty(_columns) ? "SELECT *" : "SELECT " + _columns + "\n";
        result += "FROM " + _table + "\n";
        result += string.IsNullOrEmpty(_where) ? "" : "WHERE " + _where;
        this.Reset();
        return new SqlQuery(result);
    }
}
