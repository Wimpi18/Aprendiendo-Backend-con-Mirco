using Singleton_Logger;

Logger logA = Logger.Instance;
Logger logB = Logger.Instance;
Console.Write(logA == logB);
