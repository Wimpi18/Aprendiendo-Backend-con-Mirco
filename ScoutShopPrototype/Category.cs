public class Category : IScoutProduct
{
    public string Name;

    public Category(string Name)
    {
        this.Name = Name;
    }

    public IScoutProduct Clonar()
    {
        return (Category)this.MemberwiseClone();
    }
}
