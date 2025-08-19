public class Item
{
    public string SKU { get; set; }
    public decimal Price { get; set; }
    public string Name { get; set; }
    public string Variant { get; set; }

    public Item(string sku, decimal price, string name, string variant)
    {
        SKU = sku;
        Price = price;
        Name = name;
        Variant = variant;
    }

    public override string ToString()
    {
        return $"{Name} {Price:C}";
    }
}
