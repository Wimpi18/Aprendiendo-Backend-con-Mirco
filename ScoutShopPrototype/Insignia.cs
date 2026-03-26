public class Insignia : IScoutProduct
{
    public string Name;
    public decimal BasePrice;
    public string Color;
    public Provider Provider;

    public Insignia(string name, decimal basePrice, string color, Provider provider)
    {
        this.Name = name;
        this.BasePrice = basePrice;
        this.Color = color;
        this.Provider = provider;
    }

    public IScoutProduct Clonar()
    {
        Insignia insignia = (Insignia)this.MemberwiseClone();
        insignia.Provider = new Provider(insignia.Provider.Name);
        return insignia;
    }
}
