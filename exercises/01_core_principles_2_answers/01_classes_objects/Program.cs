using System;

class InventoryItem
{
    public string Name = "Unknown";
    public double Weight;
    public int Value;

    public void Describe()
    {
        Console.WriteLine($"{Name} | Weight: {Weight} kg | Value: {Value}");
    }
}

class Program
{
    static void Main()
    {
        InventoryItem sword = new InventoryItem();
        sword.Name = "Iron Sword";
        sword.Weight = 3.5;
        sword.Value = 100;

        InventoryItem potion = new InventoryItem();
        potion.Name = "Health Potion";
        potion.Weight = 0.5;
        potion.Value = 25;

        InventoryItem key = new InventoryItem();
        key.Name = "Old Key";
        key.Weight = 0.1;
        key.Value = 5;

        sword.Describe();
        potion.Describe();
        key.Describe();
    }
}
