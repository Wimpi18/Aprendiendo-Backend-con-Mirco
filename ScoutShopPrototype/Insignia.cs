public class Insignia : IScoutProduct
{
    public string Name;
    private readonly decimal BasePrice;
    private readonly string Color;

    public Insignia(string name, decimal basePrice, string color)
    {
        this.Name = name;
        this.BasePrice = basePrice;
        this.Color = color;
    }

    private Insignia(Insignia Insignia)
    {
        this.Name = Insignia.Name;
        this.BasePrice = Insignia.BasePrice;
        this.Color = Insignia.Color;
    }

    public IScoutProduct Clonar()
    {
        return new Insignia(this);
    }
}
