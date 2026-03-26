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
        Insignia insignia = (Insignia)this.MemberwiseClone();
        insignia.Provider = (Provider)this.Provider.Clonar();
        insignia.Requirements = [.. Requirements];
        insignia.Category = (Category)this.Category.Clonar();
        return insignia;
    }
}
