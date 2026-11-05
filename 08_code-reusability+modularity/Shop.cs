class Shop
{
    public void BuyItem(Inventory inventory)
    {
        Console.WriteLine("The player buys an item.");
        inventory.AddItem(new Item("Iron Sword"));
    }
}