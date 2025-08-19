public class Basket
{
    public List<Item> Items { get; set; } = new List<Item>();
    public int MaxSize { get; set; } = 10;

    public void AddItem(Item item)
    {
        if (!IsBasketFull())
        {
            Items.Add(item);
        }
        else
        {
            Console.WriteLine("Basket is full!");
        }
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }

    public bool IsBasketFull()
    {
        if (Items.Count >= MaxSize)
        {
            return true;
        }
        else
            return false;
    }

    public bool IsItemInBasket(Item item)
    {
        return Items.Contains(item);
    }

    public decimal PriceInBasket()
    {
        decimal total = 0;
        // foreach (var item in Items)
        // {
        //     total += item.Price;
        //     foreach (var filling in item.Fillings)
        //     {
        //         total += filling.Price;
        //     }
        // }
        return total;
    }

    public override string ToString()
    {
        if (Items.Count == 0) return "Basket is empty";

        string result = "Basket contains:\n";
        foreach (var item in Items)
        {
            result += "- " + item + "\n"; 
        }
        return result;
    }
}