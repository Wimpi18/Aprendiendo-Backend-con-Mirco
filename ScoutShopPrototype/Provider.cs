public class Provider : IScoutProduct
{
    public string Name;

    public Provider(string name)
    {
        this.Name = name;
    }

    public IScoutProduct Clonar()
    {
        return (Provider)this.MemberwiseClone();
    }
}
