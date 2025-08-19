namespace exercise;

public class Receipt
{
    public Receipt()
    {
        Store store = new Store();
        Basket basket = new Basket();
        DateTime utcNow = DateTime.UtcNow;

        for (int i = 0; i < 8; i++)
        {
            basket.AddItem(store.AvailableItems[i]);
        }
        Console.WriteLine("~~~ Bobs Bagels ~~~");
        Console.WriteLine(utcNow);
        Console.WriteLine("----------------");
        Console.WriteLine(basket);
        Console.WriteLine("----------------");
        Console.WriteLine("Total " + basket.PriceInBasket() + " kr");
    }
}
