namespace exercise;

public class Store
{
    public List<Item> AvailableItems { get; private set; }

    public Store()
    {
        AvailableItems = CreateFakeItems();
    }

    private List<Item> CreateFakeItems()
    {
        return new List<Item>
        {
            // Bagels
            new Item("BGLO", 0.49m, "Bagel", "Onion"),
            new Item("BGLP", 0.39m, "Bagel", "Plain"),
            new Item("BGLE", 0.49m, "Bagel", "Everything"),
            new Item("BGLS", 0.49m, "Bagel", "Sesame"),

            // Coffee
            new Item("COFB", 0.99m, "Coffee", "Black"),
            new Item("COFW", 1.19m, "Coffee", "White"),
            new Item("COFC", 1.29m, "Coffee", "Cappuccino"),
            new Item("COFL", 1.29m, "Coffee", "Latte"),

            // Fillings
            new Item("FILB", 0.12m, "Filling", "Bacon"),
            new Item("FILE", 0.12m, "Filling", "Egg"),
            new Item("FILC", 0.12m, "Filling", "Cheese"),
            new Item("FILX", 0.12m, "Filling", "Cream Cheese"),
            new Item("FILS", 0.12m, "Filling", "Smoked Salmon"),
            new Item("FILH", 0.12m, "Filling", "Ham")
        };
    }
}