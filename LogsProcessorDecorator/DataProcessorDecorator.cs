public abstract class DataProcessorDecorator : IDataProcessor
{
    protected readonly IDataProcessor _processor;

    public DataProcessorDecorator(IDataProcessor processor)
    {
        _processor = processor;
    }

    public virtual string Process(string data)
    {
        return _processor.Process(data);
    }
}
