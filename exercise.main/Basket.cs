
namespace exercise;

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

            // This part might not make it any cleaner, but ill keep it, not great since it only checks for one type of discount
            var (fullSetsOfSix, singleBGLEPrice, remainingBGLE) = CheckforBGLE();

            // Total for all bagels
            total += fullSetsOfSix * 2.49m + remainingBGLE * singleBGLEPrice;

            // Total for all non-bagel items
            total += Items.Where(item => !item.SKU.StartsWith("BGLE"))
                        .Sum(item => item.Price);

            Console.WriteLine("To pay: " + total);
            return total;
        }

    private (int fullSetsOfSix, decimal singleBGLEPrice, int remainingBGLE) CheckforBGLE()
    {
        int BGLECount = Items.Count(item => item.SKU.StartsWith("BGLE"));
        int fullSetsOfSix = BGLECount / 6;
        int remainingBGLE = BGLECount % 6;

        decimal singleBGLEPrice = Items.FirstOrDefault(item => item.SKU.StartsWith("BGLE")).Price;
        
        return (fullSetsOfSix, singleBGLEPrice, remainingBGLE);
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