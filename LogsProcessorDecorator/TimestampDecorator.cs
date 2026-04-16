public class TimestampDecorator : DataProcessorDecorator
{
    public TimestampDecorator(IDataProcessor processor)
        : base(processor) { }

    public override string Process(string data)
    {
        return $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {_processor.Process(data)}";
    }
}
