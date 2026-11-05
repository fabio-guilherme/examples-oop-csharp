class TreasureChest
{
    public void Open(Inventory inventory)
    {
        Console.WriteLine("The chest opens.");
        inventory.AddItem(new Item("Ancient Coin"));
    }
}
