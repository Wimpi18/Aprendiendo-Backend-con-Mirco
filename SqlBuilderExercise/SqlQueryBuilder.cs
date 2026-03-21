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
        if (string.IsNullOrEmpty(query[0]))
            query[0] = tableName;
        else
            query[0] += $", {tableName}";
    }

    public void AddColumn(string columnName)
    {
        if (string.IsNullOrEmpty(query[2]))
            query[1] = columnName;
        else
            query[1] += $", {columnName}";
    }

    public void AddWhere(string condition)
    {
        if (string.IsNullOrEmpty(query[2]))
            query[2] = condition;
        else
            query[2] += $" AND {condition}";
    }

    public SqlQuery Build()
    {
        string result = "";
        result += string.IsNullOrEmpty(query[1]) ? "SELECT *" : "SELECT " + query[1] + "\n";
        result += "FROM " + query[0] + "\n";
        result += string.IsNullOrEmpty(query[2]) ? "" : "WHERE " + query[2];

        sqlQuery = new SqlQuery(result);
        return sqlQuery;
    }
}
