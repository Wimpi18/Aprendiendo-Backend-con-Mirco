public class SqlQueryBuilder
{
    SqlQuery sqlQuery;
    string[] query;

    public SqlQueryBuilder()
    {
        query = new string[3];
    }

    public void SetTable(string tableName)
    {
        if (query[0] == null)
            query[0] = tableName;
        else
            query[0] += $", {tableName}";
    }

    public void AddColumn(string columnName)
    {
        if (query[1] == null)
            query[1] = columnName;
        else
            query[1] += $", {columnName}";
    }

    public void AddWhere(string condition)
    {
        if (query[2] == null)
            query[2] = condition;
        else
            query[2] += $" AND {condition}";
    }

    public SqlQuery Build()
    {
        string result = "";
        result += query[1] == null ? "SELECT *" : "SELECT " + query[1] + "\n";
        result += "FROM " + query[0] + "\n";
        result += query[2] == null ? "" : "WHERE " + query[2];

        sqlQuery = new SqlQuery(result);
        return sqlQuery;
    }
}
