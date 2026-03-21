public class SqlQuery
{
    private string commandText;

    public SqlQuery(string commandText)
    {
        this.commandText = commandText;
    }

    public string CommandText
    {
        get => commandText;
    }
}
