public class CensorshipDecorator : DataProcessorDecorator
{
    private readonly string[] _badWords;

    public CensorshipDecorator(IDataProcessor processor, string[] badWords)
        : base(processor)
    {
        _badWords = badWords;
    }

    public override string Process(string data)
    {
        string processedData = _processor.Process(data);

        foreach (var badWord in _badWords)
        {
            processedData = processedData.Replace(badWord, "***");
        }
        return processedData;
    }
}
