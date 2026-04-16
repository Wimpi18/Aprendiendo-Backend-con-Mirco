public class ProcessorCategoryAttribute : System.Attribute
{
    public string Category { get; }

    public ProcessorCategoryAttribute(string category)
    {
        Category = category;
    }
}
