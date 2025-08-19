using exercise;

Store store = new Store();
Basket basket = new Basket();
basket.AddItem(store.AvailableItems[1]);
basket.AddItem(store.AvailableItems[2]);
basket.AddItem(store.AvailableItems[2]);
basket.AddItem(store.AvailableItems[2]);
basket.AddItem(store.AvailableItems[2]);
basket.AddItem(store.AvailableItems[2]);
basket.AddItem(store.AvailableItems[2]);
basket.AddItem(store.AvailableItems[9]);

basket.PriceInBasket();
Console.WriteLine(basket);
