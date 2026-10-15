using System;

abstract class Item
{
    public string Name { get; set; } = "Unknown";
    public int Price { get; private set; }

    protected Item(int price)
    {
        SetPrice(price);
    }

    public void SetPrice(int price)
    {
        if (price < 0)
        {
            Console.WriteLine("Price cannot be negative.");
            return;
        }

        Price = price;
    }

    public abstract void Use();
}

class Weapon : Item
{
    public Weapon(int price) : base(price) { }

    public override void Use()
    {
        Console.WriteLine(Name + " is equipped.");
    }
}

class Potion : Item
{
    public Potion(int price) : base(price) { }

    public override void Use()
    {
        Console.WriteLine(Name + " restores health.");
    }
}

class QuestItem : Item
{
    public QuestItem(int price) : base(price) { }

    public override void Use()
    {
        Console.WriteLine(Name + " advances a quest.");
    }
}

class Program
{
    static void Main()
    {
        Item[] shopItems =
        {
            new Weapon(100) { Name = "Iron Sword" },
            new Potion(25) { Name = "Health Potion" },
            new QuestItem(50) { Name = "Ancient Relic" }
        };

        foreach (Item item in shopItems)
        {
            Console.WriteLine($"{item.Name}: {item.Price} gold");
            item.Use();
        }
    }
}
