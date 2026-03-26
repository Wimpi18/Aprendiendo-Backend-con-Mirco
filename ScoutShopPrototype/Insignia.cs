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
        return (Insignia)this.MemberwiseClone();
    }
}
