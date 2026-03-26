using System.Text.Json;

public class Insignia : IScoutProduct
{
    public string Name;
    public decimal BasePrice;
    public string Color;
    public Provider Provider;
    public List<string> Requirements;
    public Category Category;

    public Insignia(
        string name,
        decimal basePrice,
        string color,
        Provider provider,
        List<string> requirements,
        Category category
    )
    {
        this.Name = name;
        this.BasePrice = basePrice;
        this.Color = color;
        this.Provider = provider;
        this.Requirements = requirements;
        this.Category = category;
    }

    public IScoutProduct Clonar()
    {
        string Serialize = JsonSerializer.Serialize(this);
        Insignia? Insignia = JsonSerializer.Deserialize<Insignia>(Serialize);
        if (Insignia == null)
            throw new Exception();

        return Insignia;
    }
}
