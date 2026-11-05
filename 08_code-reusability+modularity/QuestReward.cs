class QuestReward
{
    public void Claim(Inventory inventory)
    {
        Console.WriteLine("Quest completed!");
        inventory.AddItem(new Item("Healing Potion"));
    }
}
