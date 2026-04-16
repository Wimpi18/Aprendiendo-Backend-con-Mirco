[ProcessorCategory("Formatting")]
public class UpperCaseDecorator : DataProcessorDecorator
{
    public UpperCaseDecorator(IDataProcessor processor)
        : base(processor) { }

    public override string Process(string data)
    {
        return _processor.Process(data).ToUpper();
    }
}
