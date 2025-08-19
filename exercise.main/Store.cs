public class Store
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<Filling> Fillings { get; set; } = new List<Filling>();
    public int BasketSize { get; set; } = 10;

    public int SetBasketSize(int i)
    {
        BasketSize = i;
        return BasketSize;
    }

    public decimal PriceOfBagel(Store item)
    {
        return item.Price;
    }

    public decimal PriceOfFilling(Filling filling)
    {
        return filling.Price;
    }

    public void AddFilling(Store item, Filling filling)
    {
        item.Fillings.Add(filling);
    }

    public bool IsInStock(Store item)
    {
        return true;
    }
}