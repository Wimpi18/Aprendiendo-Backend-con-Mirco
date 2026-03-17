namespace Singleton_Logger;

public class Logger
{
    private static Logger? instance;

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }
    }

    public void registerLog(string message)
    {
        Console.WriteLine(message);
    }
}
