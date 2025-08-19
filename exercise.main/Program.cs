// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Item item = new Item("BGLO", 0.49m, "Bagel", "Onion");
Console.WriteLine(item.Price);
Basket basket = new Basket();
basket.AddItem(item);
Console.WriteLine(basket);
