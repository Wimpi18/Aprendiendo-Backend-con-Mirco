public class CatalogManager
{
    Dictionary<string, IScoutProduct> products = new Dictionary<string, IScoutProduct>();

    public void RegisterProduct(string key, IScoutProduct product)
    {
        products.Add(key, product);
    }

    public IScoutProduct GetClone(string key)
    {
        return products[key].Clonar();
    }
}
