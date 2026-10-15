using System;

class Item
{
    public string Name { get; set; } = "Unknown";

    public virtual void Use()
    {
        Console.WriteLine(Name + " is used.");
    }
}

class Weapon : Item
{
    public override void Use()
    {
        Console.WriteLine(Name + " is equipped.");
    }
}

class Potion : Item
{
    public override void Use()
    {
        Console.WriteLine(Name + " restores health.");
    }
}

class Armour : Item
{
    public override void Use()
    {
        Console.WriteLine(Name + " is equipped as armour.");
    }
}

class QuestItem : Item
{
    public override void Use()
    {
        Console.WriteLine(Name + " advances a quest.");
    }
}

class Program
{
    static void Main()
    {
        Item[] items =
        {
            new Weapon { Name = "Iron Sword" },
            new Potion { Name = "Health Potion" },
            new Armour { Name = "Leather Armour" },
            new QuestItem { Name = "Ancient Relic" }
        };

        foreach (Item item in items)
            item.Use();
    }
}
